﻿using Rock.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.reallifeministries.RockExtensions.Migrations
{
    class _006_RemoveAttendanceWorkflowsForTextAttendance : Migration
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
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.RemoveLastAttendanceFromPerson", "935CC5E6-DDFB-48C3-816D-892AF2EE2A19", false, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava", "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", false, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode", "550458E4-BBBF-4E47-955E-1DBE79352E7D", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.ActivateActivity", "38907A90-1634-4A93-8017-619326A4A582", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.SendSms", "F22FA171-B5E7-497F-9AE6-F7B98A377D0E", false, true);
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
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("935CC5E6-DDFB-48C3-816D-892AF2EE2A19", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "FEC77FF4-3395-4D8B-919E-DD0EFBC91B87"); // com.reallifeministries.RockExtensions.Workflow.Action.RemoveLastAttendanceFromPerson:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("935CC5E6-DDFB-48C3-816D-892AF2EE2A19", "33E6DF69-BDFA-407A-9744-C175B60643AE", "PersonAttribute", "PersonAttribute", "The workflow attribute containing the person.", 0, @"", "C53D4FFF-17E3-4664-A7A8-CADBC990A42A"); // com.reallifeministries.RockExtensions.Workflow.Action.RemoveLastAttendanceFromPerson:PersonAttribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("935CC5E6-DDFB-48C3-816D-892AF2EE2A19", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "98757E75-86DA-4170-B71A-ECAB9F29DB59"); // com.reallifeministries.RockExtensions.Workflow.Action.RemoveLastAttendanceFromPerson:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("F22FA171-B5E7-497F-9AE6-F7B98A377D0E", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "53C5F522-B968-4D7E-8BEE-26E49575B601"); // Rock.Workflow.Action.SendSms:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("F22FA171-B5E7-497F-9AE6-F7B98A377D0E", "3B1D93D7-9414-48F9-80E5-6A3FC8F94C20", "Message|Attribute Value", "Message", "The message or an attribute that contains the message that should be sent. <span class='tip tip-lava'></span>", 2, @"", "7943EBA0-6ADB-4127-BD3C-E5AF4C75BBC9"); // Rock.Workflow.Action.SendSms:Message|Attribute Value
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("F22FA171-B5E7-497F-9AE6-F7B98A377D0E", "3B1D93D7-9414-48F9-80E5-6A3FC8F94C20", "Recipient|Attribute Value", "To", "The phone number or an attribute that contains the person or phone number that message should be sent to. <span class='tip tip-lava'></span>", 1, @"", "FB5DCFBE-31A0-4259-8DD1-DFCDDF709A5D"); // Rock.Workflow.Action.SendSms:Recipient|Attribute Value
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("F22FA171-B5E7-497F-9AE6-F7B98A377D0E", "59D5A94C-94A0-4630-B80A-BB25697D74C7", "From", "From", "The phone number to send message from", 0, @"", "ED73C139-0EC5-4360-8345-8D42B2F8C855"); // Rock.Workflow.Action.SendSms:From
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("F22FA171-B5E7-497F-9AE6-F7B98A377D0E", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "C34E2D58-D2D0-48D7-8BBC-2973C5D2B03A"); // Rock.Workflow.Action.SendSms:Order
            RockMigrationHelper.UpdateWorkflowType(false, true, "Text Remove Attendance Record", "Number '5' in the text attendance system", "B22885AB-0DBD-4115-9484-626D795AC2CE", "Work", "fa fa-list-ol", 0, true, 0, "A74396B8-4723-4BE7-9F4A-14506C921FC8"); // Text Remove Attendance Record
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "E4EAB7B2-0B76-429B-AFE4-AD86D7428C70", "FromPerson", "FromPerson", "", 0, @"57999151-81e4-4ecb-8643-431617278eb3", "38C52F6F-E08A-4FCF-BD87-AEA0F7C50CC1"); // Text Remove Attendance Record:FromPerson
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPersonAttendanceCode", "FromPersonAttendanceCode", "", 1, @"", "8F7DEFBC-9B37-41C8-93FA-6896FE9703AD"); // Text Remove Attendance Record:FromPersonAttendanceCode
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "AttendanceKey", "AttendanceKey", "", 3, @"", "6C319361-6841-4A22-9EA3-CFDDBBDB469E"); // Text Remove Attendance Record:AttendanceKey
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "AttendanceCode", "AttendanceCode", "", 4, @"", "D3B602DA-25A0-41E0-8624-2047EC8C2D4C"); // Text Remove Attendance Record:AttendanceCode
            RockMigrationHelper.UpdateWorkflowTypeAttribute("A74396B8-4723-4BE7-9F4A-14506C921FC8", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPhone", "FromPhone", "", 2, @"+12086910479", "5062C47D-5572-4629-8881-1C51E09BC8A4"); // Text Remove Attendance Record:FromPhone
            RockMigrationHelper.AddAttributeQualifier("8F7DEFBC-9B37-41C8-93FA-6896FE9703AD", "ispassword", @"False", "88081DD9-3276-4F6A-8E90-2A1C7A94C340"); // Text Remove Attendance Record:FromPersonAttendanceCode:ispassword
            RockMigrationHelper.AddAttributeQualifier("6C319361-6841-4A22-9EA3-CFDDBBDB469E", "ispassword", @"False", "95F88DC2-6861-4A8B-A47B-54A9DB48BFC8"); // Text Remove Attendance Record:AttendanceKey:ispassword
            RockMigrationHelper.AddAttributeQualifier("D3B602DA-25A0-41E0-8624-2047EC8C2D4C", "ispassword", @"False", "5C28A3DF-0BAB-45FD-9764-9FFA8D0C46FB"); // Text Remove Attendance Record:AttendanceCode:ispassword
            RockMigrationHelper.AddAttributeQualifier("5062C47D-5572-4629-8881-1C51E09BC8A4", "ispassword", @"False", "CA94E1C2-4038-4299-94CA-3D0E039BE446"); // Text Remove Attendance Record:FromPhone:ispassword
            RockMigrationHelper.UpdateWorkflowActivityType("A74396B8-4723-4BE7-9F4A-14506C921FC8", true, "Validate Attendance Code", "validates a correct attendance code", true, 0, "70A5E5F0-F8DD-4D2C-ABE1-885F1D83D711"); // Text Remove Attendance Record:Validate Attendance Code
            RockMigrationHelper.UpdateWorkflowActivityType("A74396B8-4723-4BE7-9F4A-14506C921FC8", true, "Remove From Current Attendance", "Removes the person from the current attendance", false, 1, "C255985A-A395-4975-8AB6-3910CC88A31C"); // Text Remove Attendance Record:Remove From Current Attendance
            RockMigrationHelper.UpdateWorkflowActionType("70A5E5F0-F8DD-4D2C-ABE1-885F1D83D711", "Activate Remove From Attendance", 2, "38907A90-1634-4A93-8017-619326A4A582", true, false, "", "D3B602DA-25A0-41E0-8624-2047EC8C2D4C", 64, "", "DD4E1E3C-66E8-4462-96C8-59FBB912C210"); // Text Remove Attendance Record:Validate Attendance Code:Activate Remove From Attendance
            RockMigrationHelper.UpdateWorkflowActionType("C255985A-A395-4975-8AB6-3910CC88A31C", "Send SMS Message", 1, "F22FA171-B5E7-497F-9AE6-F7B98A377D0E", true, false, "", "", 1, "", "8341ED44-451B-4BA8-BAAC-85FC64E779E4"); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message
            RockMigrationHelper.UpdateWorkflowActionType("70A5E5F0-F8DD-4D2C-ABE1-885F1D83D711", "get Attendance Code from Person", 0, "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", true, false, "", "", 1, "", "EAF92D28-EA7E-4A55-9280-3EAB8742C6E5"); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person
            RockMigrationHelper.UpdateWorkflowActionType("70A5E5F0-F8DD-4D2C-ABE1-885F1D83D711", "Validate code", 1, "550458E4-BBBF-4E47-955E-1DBE79352E7D", true, false, "", "", 1, "", "4F52CFA6-AF2E-4DA9-86B1-FA074F21BE65"); // Text Remove Attendance Record:Validate Attendance Code:Validate code
            RockMigrationHelper.UpdateWorkflowActionType("C255985A-A395-4975-8AB6-3910CC88A31C", "Remove Last Attendance From person", 0, "935CC5E6-DDFB-48C3-816D-892AF2EE2A19", true, false, "", "", 1, "", "5FC8D82D-EFBF-457E-8416-03CB6E17C695"); // Text Remove Attendance Record:Remove From Current Attendance:Remove Last Attendance From person
            RockMigrationHelper.AddActionTypeAttributeValue("EAF92D28-EA7E-4A55-9280-3EAB8742C6E5", "CF19BB9A-EA5B-43E5-89A1-FA416F430761", @"38c52f6f-e08a-4fcf-bd87-aea0f7c50cc1"); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person:PersonAttribute
            RockMigrationHelper.AddActionTypeAttributeValue("EAF92D28-EA7E-4A55-9280-3EAB8742C6E5", "40FF47A2-9682-4545-BDF3-171B5F6B8A5C", @"8f7defbc-9b37-41c8-93fa-6896fe9703ad"); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person:Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("EAF92D28-EA7E-4A55-9280-3EAB8742C6E5", "52930E88-A86E-47AE-BB1D-9937692BBF74", @"{{ Person.LastAttendanceCode }}"); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person:Lava
            RockMigrationHelper.AddActionTypeAttributeValue("EAF92D28-EA7E-4A55-9280-3EAB8742C6E5", "E7527DBD-32B1-47CE-8D22-142EDE32BD7D", @""); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person:Order
            RockMigrationHelper.AddActionTypeAttributeValue("EAF92D28-EA7E-4A55-9280-3EAB8742C6E5", "8DE0F372-4B1C-4612-B318-E598E4CC17F8", @"False"); // Text Remove Attendance Record:Validate Attendance Code:get Attendance Code from Person:Active
            RockMigrationHelper.AddActionTypeAttributeValue("4F52CFA6-AF2E-4DA9-86B1-FA074F21BE65", "0FC7338D-F75D-401F-8F03-ADDA92315A3B", @"{{Workflow.FromPersonAttendanceCode}}"); // Text Remove Attendance Record:Validate Attendance Code:Validate code:UserInputCode
            RockMigrationHelper.AddActionTypeAttributeValue("4F52CFA6-AF2E-4DA9-86B1-FA074F21BE65", "18BA2FE7-7620-42CE-8FD8-727A26683B81", @""); // Text Remove Attendance Record:Validate Attendance Code:Validate code:Order
            RockMigrationHelper.AddActionTypeAttributeValue("4F52CFA6-AF2E-4DA9-86B1-FA074F21BE65", "C9FC261D-84BF-41F7-9636-734EAAF0FD86", @"False"); // Text Remove Attendance Record:Validate Attendance Code:Validate code:Active
            RockMigrationHelper.AddActionTypeAttributeValue("DD4E1E3C-66E8-4462-96C8-59FBB912C210", "E8ABD802-372C-47BE-82B1-96F50DB5169E", @"False"); // Text Remove Attendance Record:Validate Attendance Code:Activate Remove From Attendance:Active
            RockMigrationHelper.AddActionTypeAttributeValue("DD4E1E3C-66E8-4462-96C8-59FBB912C210", "3809A78C-B773-440C-8E3F-A8E81D0DAE08", @""); // Text Remove Attendance Record:Validate Attendance Code:Activate Remove From Attendance:Order
            RockMigrationHelper.AddActionTypeAttributeValue("DD4E1E3C-66E8-4462-96C8-59FBB912C210", "02D5A7A5-8781-46B4-B9FC-AF816829D240", @"C255985A-A395-4975-8AB6-3910CC88A31C"); // Text Remove Attendance Record:Validate Attendance Code:Activate Remove From Attendance:Activity
            RockMigrationHelper.AddActionTypeAttributeValue("5FC8D82D-EFBF-457E-8416-03CB6E17C695", "C53D4FFF-17E3-4664-A7A8-CADBC990A42A", @"38c52f6f-e08a-4fcf-bd87-aea0f7c50cc1"); // Text Remove Attendance Record:Remove From Current Attendance:Remove Last Attendance From person:PersonAttribute
            RockMigrationHelper.AddActionTypeAttributeValue("5FC8D82D-EFBF-457E-8416-03CB6E17C695", "98757E75-86DA-4170-B71A-ECAB9F29DB59", @""); // Text Remove Attendance Record:Remove From Current Attendance:Remove Last Attendance From person:Order
            RockMigrationHelper.AddActionTypeAttributeValue("5FC8D82D-EFBF-457E-8416-03CB6E17C695", "FEC77FF4-3395-4D8B-919E-DD0EFBC91B87", @"False"); // Text Remove Attendance Record:Remove From Current Attendance:Remove Last Attendance From person:Active
            RockMigrationHelper.AddActionTypeAttributeValue("8341ED44-451B-4BA8-BAAC-85FC64E779E4", "ED73C139-0EC5-4360-8345-8D42B2F8C855", @"42eddbfb-fdc8-4b23-9b15-4a0f8c5cde93"); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message:From
            RockMigrationHelper.AddActionTypeAttributeValue("8341ED44-451B-4BA8-BAAC-85FC64E779E4", "C34E2D58-D2D0-48D7-8BBC-2973C5D2B03A", @""); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message:Order
            RockMigrationHelper.AddActionTypeAttributeValue("8341ED44-451B-4BA8-BAAC-85FC64E779E4", "53C5F522-B968-4D7E-8BEE-26E49575B601", @"False"); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message:Active
            RockMigrationHelper.AddActionTypeAttributeValue("8341ED44-451B-4BA8-BAAC-85FC64E779E4", "FB5DCFBE-31A0-4259-8DD1-DFCDDF709A5D", @"5062c47d-5572-4629-8881-1c51e09bc8a4"); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message:Recipient|Attribute Value
            RockMigrationHelper.AddActionTypeAttributeValue("8341ED44-451B-4BA8-BAAC-85FC64E779E4", "7943EBA0-6ADB-4127-BD3C-E5AF4C75BBC9", @"Thank you. Please remember to fill out a connection card."); // Text Remove Attendance Record:Remove From Current Attendance:Send SMS Message:Message|Attribute Value
        }
    }
}
