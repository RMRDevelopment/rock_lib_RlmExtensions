﻿using Rock.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.reallifeministries.RockExtensions.Migrations
{
    class _003_AddWorkflowsForTextAttendance : Migration
    {
        public override void Down()
        {
            
        }

        public override void Up()
        {
            RockMigrationHelper.UpdateFieldType("Range Slider", "", "Rock", "Rock.Field.Types.RangeSliderFieldType", "E239F99B-09EE-4AAE-8AA9-53E03EE45F19");
            RockMigrationHelper.UpdateEntityType("Rock.Model.Workflow", "3540E9A7-FE30-43A9-8B0A-A372B63DFC93", true, true);
            RockMigrationHelper.UpdateEntityType("Rock.Model.WorkflowActivity", "2CB52ED0-CB06-4D62-9E2C-73B60AFA4C9F", true, true);
            RockMigrationHelper.UpdateEntityType("Rock.Model.WorkflowActionType", "23E3273A-B137-48A3-9AFF-C8DC832DDCA6", true, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.AddPrayerRequestToPerson", "002072DD-D1BD-4847-9E76-AB32A2759A1C", false, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava", "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", false, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode", "550458E4-BBBF-4E47-955E-1DBE79352E7D", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.ActivateActivity", "38907A90-1634-4A93-8017-619326A4A582", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.SendSms", "F22FA171-B5E7-497F-9AE6-F7B98A377D0E", false, true);
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("002072DD-D1BD-4847-9E76-AB32A2759A1C", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "94DE22EA-8B90-4F64-A935-738D4ACE2D41"); // com.reallifeministries.RockExtensions.Workflow.Action.AddPrayerRequestToPerson:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("002072DD-D1BD-4847-9E76-AB32A2759A1C", "33E6DF69-BDFA-407A-9744-C175B60643AE", "PersonAttribute", "PersonAttribute", "The workflow attribute containing the person.", 0, @"", "D4FB998C-D1EE-498A-A3D4-B76EABD85232"); // com.reallifeministries.RockExtensions.Workflow.Action.AddPrayerRequestToPerson:PersonAttribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("002072DD-D1BD-4847-9E76-AB32A2759A1C", "9C204CD0-1233-41C5-818A-C5DA439445AA", "PrayerRequest", "PrayerRequest", "The Prayer Request to be Saved", 0, @"", "3C8252EB-B6BB-478E-9B1E-415EFC63A070"); // com.reallifeministries.RockExtensions.Workflow.Action.AddPrayerRequestToPerson:PrayerRequest
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("002072DD-D1BD-4847-9E76-AB32A2759A1C", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "1CB187A7-B292-4DC8-B584-ABF4CD25C596"); // com.reallifeministries.RockExtensions.Workflow.Action.AddPrayerRequestToPerson:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("38907A90-1634-4A93-8017-619326A4A582", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "E8ABD802-372C-47BE-82B1-96F50DB5169E"); // Rock.Workflow.Action.ActivateActivity:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("38907A90-1634-4A93-8017-619326A4A582", "739FD425-5B8C-4605-B775-7E4D9D4C11DB", "Activity", "Activity", "The activity type to activate", 0, @"", "02D5A7A5-8781-46B4-B9FC-AF816829D240"); // Rock.Workflow.Action.ActivateActivity:Activity
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("38907A90-1634-4A93-8017-619326A4A582", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "3809A78C-B773-440C-8E3F-A8E81D0DAE08"); // Rock.Workflow.Action.ActivateActivity:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("550458E4-BBBF-4E47-955E-1DBE79352E7D", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "C9FC261D-84BF-41F7-9636-734EAAF0FD86"); // com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("550458E4-BBBF-4E47-955E-1DBE79352E7D", "9C204CD0-1233-41C5-818A-C5DA439445AA", "UserInputCode", "UserInputCode", "The code submitted by the user", 0, @"", "0FC7338D-F75D-401F-8F03-ADDA92315A3B"); // com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode:UserInputCode
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("550458E4-BBBF-4E47-955E-1DBE79352E7D", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "18BA2FE7-7620-42CE-8FD8-727A26683B81"); // com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "8DE0F372-4B1C-4612-B318-E598E4CC17F8"); // com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Attribute", "Attribute", "The workflow attribute you will be setting", 0, @"", "40FF47A2-9682-4545-BDF3-171B5F6B8A5C"); // com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava:Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", "33E6DF69-BDFA-407A-9744-C175B60643AE", "PersonAttribute", "PersonAttribute", "The workflow attribute containing the person.", 0, @"", "CF19BB9A-EA5B-43E5-89A1-FA416F430761"); // com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava:PersonAttribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "Lava", "Lava", "Lava to use when setting the attribute.  Normal Workflow merge fields will be available, as well as: {{Person}} which will be the Person model corresponding to the selected Person Attribute", 0, @"", "52930E88-A86E-47AE-BB1D-9937692BBF74"); // com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava:Lava
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "E7527DBD-32B1-47CE-8D22-142EDE32BD7D"); // com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("F22FA171-B5E7-497F-9AE6-F7B98A377D0E", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "53C5F522-B968-4D7E-8BEE-26E49575B601"); // Rock.Workflow.Action.SendSms:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("F22FA171-B5E7-497F-9AE6-F7B98A377D0E", "3B1D93D7-9414-48F9-80E5-6A3FC8F94C20", "Message|Attribute Value", "Message", "The message or an attribute that contains the message that should be sent. <span class='tip tip-lava'></span>", 2, @"", "7943EBA0-6ADB-4127-BD3C-E5AF4C75BBC9"); // Rock.Workflow.Action.SendSms:Message|Attribute Value
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("F22FA171-B5E7-497F-9AE6-F7B98A377D0E", "3B1D93D7-9414-48F9-80E5-6A3FC8F94C20", "Recipient|Attribute Value", "To", "The phone number or an attribute that contains the person or phone number that message should be sent to. <span class='tip tip-lava'></span>", 1, @"", "FB5DCFBE-31A0-4259-8DD1-DFCDDF709A5D"); // Rock.Workflow.Action.SendSms:Recipient|Attribute Value
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("F22FA171-B5E7-497F-9AE6-F7B98A377D0E", "59D5A94C-94A0-4630-B80A-BB25697D74C7", "From", "From", "The phone number to send message from", 0, @"", "ED73C139-0EC5-4360-8345-8D42B2F8C855"); // Rock.Workflow.Action.SendSms:From
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("F22FA171-B5E7-497F-9AE6-F7B98A377D0E", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "C34E2D58-D2D0-48D7-8BBC-2973C5D2B03A"); // Rock.Workflow.Action.SendSms:Order
            RockMigrationHelper.UpdateWorkflowType(false, true, "Text Prayer Request", "Option '2' in the text in attendance system", "B22885AB-0DBD-4115-9484-626D795AC2CE", "Work", "fa fa-list-ol", 0, true, 0, "88978527-0CA4-4C52-8FDA-CF915FAFA472"); // Text Prayer Request
            RockMigrationHelper.UpdateWorkflowTypeAttribute("88978527-0CA4-4C52-8FDA-CF915FAFA472", "E4EAB7B2-0B76-429B-AFE4-AD86D7428C70", "FromPerson", "FromPerson", "", 0, @"57999151-81e4-4ecb-8643-431617278eb3", "6A5B5E7E-5DF8-49DC-8DAC-7471CAC2E6B7"); // Text Prayer Request:FromPerson
            RockMigrationHelper.UpdateWorkflowTypeAttribute("88978527-0CA4-4C52-8FDA-CF915FAFA472", "9C204CD0-1233-41C5-818A-C5DA439445AA", "MessageBody", "MessageBody", "", 1, @"3 Please pray for my dog fluffy, she is very sad.", "A9880B43-6D9F-4FE6-B0E9-FD0D7133C9B6"); // Text Prayer Request:MessageBody
            RockMigrationHelper.UpdateWorkflowTypeAttribute("88978527-0CA4-4C52-8FDA-CF915FAFA472", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPersonAttendanceCode", "FromPersonAttendanceCode", "", 2, @"", "FE8CBB97-A27D-466D-95EF-3A98F27B33C0"); // Text Prayer Request:FromPersonAttendanceCode
            RockMigrationHelper.UpdateWorkflowTypeAttribute("88978527-0CA4-4C52-8FDA-CF915FAFA472", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPhone", "FromPhone", "", 3, @"+12086910479", "D492B575-0481-40E0-99A8-0EE8F74AABB2"); // Text Prayer Request:FromPhone
            RockMigrationHelper.UpdateWorkflowTypeAttribute("88978527-0CA4-4C52-8FDA-CF915FAFA472", "9C204CD0-1233-41C5-818A-C5DA439445AA", "AttendanceKey", "AttendanceKey", "", 4, @"", "8B14788A-9EED-4C87-8291-0E1E5158D25F"); // Text Prayer Request:AttendanceKey
            RockMigrationHelper.UpdateWorkflowTypeAttribute("88978527-0CA4-4C52-8FDA-CF915FAFA472", "9C204CD0-1233-41C5-818A-C5DA439445AA", "AttendanceCode", "AttendanceCode", "", 5, @"", "A97EF2C7-2A43-4DFE-9E71-2CCEF06EF474"); // Text Prayer Request:AttendanceCode
            RockMigrationHelper.AddAttributeQualifier("A9880B43-6D9F-4FE6-B0E9-FD0D7133C9B6", "ispassword", @"False", "3F7AB935-6CFD-4290-956B-BA2A7AFDD57F"); // Text Prayer Request:MessageBody:ispassword
            RockMigrationHelper.AddAttributeQualifier("FE8CBB97-A27D-466D-95EF-3A98F27B33C0", "ispassword", @"False", "FFBE8BE6-0FAC-42D1-AACF-F90C17C1E9A8"); // Text Prayer Request:FromPersonAttendanceCode:ispassword
            RockMigrationHelper.AddAttributeQualifier("D492B575-0481-40E0-99A8-0EE8F74AABB2", "ispassword", @"False", "3BDA4864-3D5E-4EA3-8F5D-9E1C1E71F322"); // Text Prayer Request:FromPhone:ispassword
            RockMigrationHelper.AddAttributeQualifier("8B14788A-9EED-4C87-8291-0E1E5158D25F", "ispassword", @"False", "8E8B100F-1310-463D-A4BF-C1B8E370735B"); // Text Prayer Request:AttendanceKey:ispassword
            RockMigrationHelper.AddAttributeQualifier("A97EF2C7-2A43-4DFE-9E71-2CCEF06EF474", "ispassword", @"False", "032E54D9-AD14-4120-A808-52698BC47788"); // Text Prayer Request:AttendanceCode:ispassword
            RockMigrationHelper.UpdateWorkflowActivityType("88978527-0CA4-4C52-8FDA-CF915FAFA472", true, "Validate Attendance Code", "validates a correct attendance code", true, 0, "2F840BFD-1014-4153-A84E-7703BDB46833"); // Text Prayer Request:Validate Attendance Code
            RockMigrationHelper.UpdateWorkflowActivityType("88978527-0CA4-4C52-8FDA-CF915FAFA472", true, "Submit Prayer Request", "Submit Prayer Request", false, 1, "2CD3E7E4-04B5-406C-9886-7AA64B42D19B"); // Text Prayer Request:Submit Prayer Request
            RockMigrationHelper.UpdateWorkflowActionType("2F840BFD-1014-4153-A84E-7703BDB46833", "Activate Prayer Request", 2, "38907A90-1634-4A93-8017-619326A4A582", true, false, "", "A97EF2C7-2A43-4DFE-9E71-2CCEF06EF474", 64, "", "7B451D7D-E370-49BA-BB72-111846D4E8D7"); // Text Prayer Request:Validate Attendance Code:Activate Prayer Request
            RockMigrationHelper.UpdateWorkflowActionType("2CD3E7E4-04B5-406C-9886-7AA64B42D19B", "Send Thank You SMS", 1, "F22FA171-B5E7-497F-9AE6-F7B98A377D0E", true, false, "", "", 1, "", "00ABF4A1-3E66-48B7-8CAF-4F42BF69F1F1"); // Text Prayer Request:Submit Prayer Request:Send Thank You SMS
            RockMigrationHelper.UpdateWorkflowActionType("2F840BFD-1014-4153-A84E-7703BDB46833", "get Attendance Code from Person", 0, "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", true, false, "", "", 1, "", "DBF96D3C-553C-4BD5-82F5-D43B15F9406F"); // Text Prayer Request:Validate Attendance Code:get Attendance Code from Person
            RockMigrationHelper.UpdateWorkflowActionType("2F840BFD-1014-4153-A84E-7703BDB46833", "Validate code", 1, "550458E4-BBBF-4E47-955E-1DBE79352E7D", true, false, "", "", 1, "", "D5AC61D0-69BE-4BD1-8A6D-1D3B2DD7BFA8"); // Text Prayer Request:Validate Attendance Code:Validate code
            RockMigrationHelper.UpdateWorkflowActionType("2CD3E7E4-04B5-406C-9886-7AA64B42D19B", "Add Prayer to Person", 0, "002072DD-D1BD-4847-9E76-AB32A2759A1C", true, false, "", "", 1, "", "0E9DC548-A1BF-4E1D-8438-A686BC492A42"); // Text Prayer Request:Submit Prayer Request:Add Prayer to Person
            RockMigrationHelper.AddActionTypeAttributeValue("DBF96D3C-553C-4BD5-82F5-D43B15F9406F", "CF19BB9A-EA5B-43E5-89A1-FA416F430761", @"6a5b5e7e-5df8-49dc-8dac-7471cac2e6b7"); // Text Prayer Request:Validate Attendance Code:get Attendance Code from Person:PersonAttribute
            RockMigrationHelper.AddActionTypeAttributeValue("DBF96D3C-553C-4BD5-82F5-D43B15F9406F", "40FF47A2-9682-4545-BDF3-171B5F6B8A5C", @"fe8cbb97-a27d-466d-95ef-3a98f27b33c0"); // Text Prayer Request:Validate Attendance Code:get Attendance Code from Person:Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("DBF96D3C-553C-4BD5-82F5-D43B15F9406F", "52930E88-A86E-47AE-BB1D-9937692BBF74", @"{{ Person.LastAttendanceCode }}"); // Text Prayer Request:Validate Attendance Code:get Attendance Code from Person:Lava
            RockMigrationHelper.AddActionTypeAttributeValue("DBF96D3C-553C-4BD5-82F5-D43B15F9406F", "E7527DBD-32B1-47CE-8D22-142EDE32BD7D", @""); // Text Prayer Request:Validate Attendance Code:get Attendance Code from Person:Order
            RockMigrationHelper.AddActionTypeAttributeValue("DBF96D3C-553C-4BD5-82F5-D43B15F9406F", "8DE0F372-4B1C-4612-B318-E598E4CC17F8", @"False"); // Text Prayer Request:Validate Attendance Code:get Attendance Code from Person:Active
            RockMigrationHelper.AddActionTypeAttributeValue("D5AC61D0-69BE-4BD1-8A6D-1D3B2DD7BFA8", "0FC7338D-F75D-401F-8F03-ADDA92315A3B", @"{{Workflow.FromPersonAttendanceCode}}"); // Text Prayer Request:Validate Attendance Code:Validate code:UserInputCode
            RockMigrationHelper.AddActionTypeAttributeValue("D5AC61D0-69BE-4BD1-8A6D-1D3B2DD7BFA8", "18BA2FE7-7620-42CE-8FD8-727A26683B81", @""); // Text Prayer Request:Validate Attendance Code:Validate code:Order
            RockMigrationHelper.AddActionTypeAttributeValue("D5AC61D0-69BE-4BD1-8A6D-1D3B2DD7BFA8", "C9FC261D-84BF-41F7-9636-734EAAF0FD86", @"False"); // Text Prayer Request:Validate Attendance Code:Validate code:Active
            RockMigrationHelper.AddActionTypeAttributeValue("7B451D7D-E370-49BA-BB72-111846D4E8D7", "E8ABD802-372C-47BE-82B1-96F50DB5169E", @"False"); // Text Prayer Request:Validate Attendance Code:Activate Prayer Request:Active
            RockMigrationHelper.AddActionTypeAttributeValue("7B451D7D-E370-49BA-BB72-111846D4E8D7", "3809A78C-B773-440C-8E3F-A8E81D0DAE08", @""); // Text Prayer Request:Validate Attendance Code:Activate Prayer Request:Order
            RockMigrationHelper.AddActionTypeAttributeValue("7B451D7D-E370-49BA-BB72-111846D4E8D7", "02D5A7A5-8781-46B4-B9FC-AF816829D240", @"2CD3E7E4-04B5-406C-9886-7AA64B42D19B"); // Text Prayer Request:Validate Attendance Code:Activate Prayer Request:Activity
            RockMigrationHelper.AddActionTypeAttributeValue("0E9DC548-A1BF-4E1D-8438-A686BC492A42", "D4FB998C-D1EE-498A-A3D4-B76EABD85232", @"6a5b5e7e-5df8-49dc-8dac-7471cac2e6b7"); // Text Prayer Request:Submit Prayer Request:Add Prayer to Person:PersonAttribute
            RockMigrationHelper.AddActionTypeAttributeValue("0E9DC548-A1BF-4E1D-8438-A686BC492A42", "3C8252EB-B6BB-478E-9B1E-415EFC63A070", @"{{Workflow.MessageBody}}"); // Text Prayer Request:Submit Prayer Request:Add Prayer to Person:PrayerRequest
            RockMigrationHelper.AddActionTypeAttributeValue("0E9DC548-A1BF-4E1D-8438-A686BC492A42", "1CB187A7-B292-4DC8-B584-ABF4CD25C596", @""); // Text Prayer Request:Submit Prayer Request:Add Prayer to Person:Order
            RockMigrationHelper.AddActionTypeAttributeValue("0E9DC548-A1BF-4E1D-8438-A686BC492A42", "94DE22EA-8B90-4F64-A935-738D4ACE2D41", @"False"); // Text Prayer Request:Submit Prayer Request:Add Prayer to Person:Active
            RockMigrationHelper.AddActionTypeAttributeValue("00ABF4A1-3E66-48B7-8CAF-4F42BF69F1F1", "ED73C139-0EC5-4360-8345-8D42B2F8C855", @"42eddbfb-fdc8-4b23-9b15-4a0f8c5cde93"); // Text Prayer Request:Submit Prayer Request:Send Thank You SMS:From
            RockMigrationHelper.AddActionTypeAttributeValue("00ABF4A1-3E66-48B7-8CAF-4F42BF69F1F1", "C34E2D58-D2D0-48D7-8BBC-2973C5D2B03A", @""); // Text Prayer Request:Submit Prayer Request:Send Thank You SMS:Order
            RockMigrationHelper.AddActionTypeAttributeValue("00ABF4A1-3E66-48B7-8CAF-4F42BF69F1F1", "53C5F522-B968-4D7E-8BEE-26E49575B601", @"False"); // Text Prayer Request:Submit Prayer Request:Send Thank You SMS:Active
            RockMigrationHelper.AddActionTypeAttributeValue("00ABF4A1-3E66-48B7-8CAF-4F42BF69F1F1", "FB5DCFBE-31A0-4259-8DD1-DFCDDF709A5D", @"d492b575-0481-40e0-99a8-0ee8f74aabb2"); // Text Prayer Request:Submit Prayer Request:Send Thank You SMS:Recipient|Attribute Value
            RockMigrationHelper.AddActionTypeAttributeValue("00ABF4A1-3E66-48B7-8CAF-4F42BF69F1F1", "7943EBA0-6ADB-4127-BD3C-E5AF4C75BBC9", @"Thank you for your prayer request."); // Text Prayer Request:Submit Prayer Request:Send Thank You SMS:Message|Attribute Value

        }
    }
}
