using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.Composition;

using Rock;
using Rock.Attribute;
using Rock.Data;
using Rock.Model;
using Rock.Workflow;

namespace com.reallifeministries.RockExtensions.Workflow.Action
{
    /// <summary>
    /// Activates a new activity for a given activity type
    /// </summary>
    [Description( "Validates attendence code to determine if it matches the system generated one" )]
    [Export( typeof( ActionComponent ) )]
    [ExportMetadata( "ComponentName", "Validate Attendence Code" )]
        
    [TextField("UserInputCode", "The code submitted by the user", true)]
    public class ValidateAttendenceCode : ActionComponent
    {
        /// <summary>
        /// Executes the specified workflow.
        /// </summary>
        /// <param name="rockContext">The rock context.</param>
        /// <param name="action">The action.</param>
        /// <param name="entity">The entity.</param>
        /// <param name="errorMessages">The error messages.</param>
        /// <returns></returns>
        public override bool Execute( RockContext rockContext, WorkflowAction action, Object entity, out List<string> errorMessages )
        {
            errorMessages = new List<string>();
            var globalAttributes = Rock.Web.Cache.GlobalAttributesCache.Read();            
            var attendenceCodes = new Dictionary<AttendenceCode, String>();
            attendenceCodes.Add(AttendenceCode.PF, globalAttributes.GetValue("PFAttendenceCode"));
            attendenceCodes.Add(AttendenceCode.CDA, globalAttributes.GetValue("CDAAttendenceCode"));
            attendenceCodes.Add(AttendenceCode.THIRST, globalAttributes.GetValue("THIRSTAttendenceCode"));
            attendenceCodes.Add(AttendenceCode.RECOVERY, globalAttributes.GetValue("RECOVERYAttendenceCode"));

            var userInputtedCode = GetAttributeValue(action, "UserInputCode").ResolveMergeFields(GetMergeFields(action));
            // parse the userInputtedCode
            var parsedInput = RemoveWhitespace(userInputtedCode);
            parsedInput = parsedInput.ToLower();
            // check to see if the generatedcode matches
            if (!String.IsNullOrEmpty(parsedInput)) {
                var match = attendenceCodes.Where(v => v.Value == parsedInput).FirstOrDefault();
                if (match.Value != null)
                {
                    var currentActivity = action.Activity;
                    currentActivity.SetAttributeValue("AttendenceKey", match.Key.ToString());
                    currentActivity.SaveAttributeValues();
                    return true;
                }
            }

            return true;            
        }
        public string RemoveWhitespace(string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
    }
}
