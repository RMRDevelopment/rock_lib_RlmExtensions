﻿using Rock.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.reallifeministries.RockExtensions.Migrations
{
    [MigrationNumber(6, "1.2.0")]
    class _004_HomegroupConnectionAddWorkflowsForTextAttendance : Migration
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
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.SetAttributeFromPersonLava", "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", false, true);
            RockMigrationHelper.UpdateEntityType("com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode", "550458E4-BBBF-4E47-955E-1DBE79352E7D", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.ActivateActivity", "38907A90-1634-4A93-8017-619326A4A582", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.CreateConnectionRequest", "70470236-7B36-4161-8B15-11ABB47B872B", false, true);
            RockMigrationHelper.UpdateEntityType("Rock.Workflow.Action.SendSms", "F22FA171-B5E7-497F-9AE6-F7B98A377D0E", false, true);
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("38907A90-1634-4A93-8017-619326A4A582", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "E8ABD802-372C-47BE-82B1-96F50DB5169E"); // Rock.Workflow.Action.ActivateActivity:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("38907A90-1634-4A93-8017-619326A4A582", "739FD425-5B8C-4605-B775-7E4D9D4C11DB", "Activity", "Activity", "The activity type to activate", 0, @"", "02D5A7A5-8781-46B4-B9FC-AF816829D240"); // Rock.Workflow.Action.ActivateActivity:Activity
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("38907A90-1634-4A93-8017-619326A4A582", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "3809A78C-B773-440C-8E3F-A8E81D0DAE08"); // Rock.Workflow.Action.ActivateActivity:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("550458E4-BBBF-4E47-955E-1DBE79352E7D", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "C9FC261D-84BF-41F7-9636-734EAAF0FD86"); // com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("550458E4-BBBF-4E47-955E-1DBE79352E7D", "9C204CD0-1233-41C5-818A-C5DA439445AA", "UserInputCode", "UserInputCode", "The code submitted by the user", 0, @"", "0FC7338D-F75D-401F-8F03-ADDA92315A3B"); // com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode:UserInputCode
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("550458E4-BBBF-4E47-955E-1DBE79352E7D", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "18BA2FE7-7620-42CE-8FD8-727A26683B81"); // com.reallifeministries.RockExtensions.Workflow.Action.ValidateAttendanceCode:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("70470236-7B36-4161-8B15-11ABB47B872B", "1EDAFDED-DFE6-4334-B019-6EECBA89E05A", "Active", "Active", "Should Service be used?", 0, @"False", "F866CF22-D18F-4759-9051-94A853F6EA43"); // Rock.Workflow.Action.CreateConnectionRequest:Active
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("70470236-7B36-4161-8B15-11ABB47B872B", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Campus Attribute", "CampusAttribute", "An optional attribute that contains the campus to use for the request.", 4, @"", "EC54AF83-6AD5-4A77-98EA-97FAABA83794"); // Rock.Workflow.Action.CreateConnectionRequest:Campus Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("70470236-7B36-4161-8B15-11ABB47B872B", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Connection Opportunity Attribute", "ConnectionOpportunityAttribute", "The attribute that contains the type of connection opportunity to create.", 1, @"", "0EA48DF4-A65C-4FD3-9475-5E72021D51D4"); // Rock.Workflow.Action.CreateConnectionRequest:Connection Opportunity Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("70470236-7B36-4161-8B15-11ABB47B872B", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Connection Request Attribute", "ConnectionRequestAttribute", "An optional connection request attribute to store the request that is created.", 5, @"", "295264F8-0EEF-4D87-A874-AD72EF8BFEB9"); // Rock.Workflow.Action.CreateConnectionRequest:Connection Request Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("70470236-7B36-4161-8B15-11ABB47B872B", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Connection Status Attribute", "ConnectionStatusAttribute", "The attribute that contains the connection status to use for the new request.", 2, @"", "DB13FD7B-7AA4-4D6F-9146-ABF68D9AEFAB"); // Rock.Workflow.Action.CreateConnectionRequest:Connection Status Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("70470236-7B36-4161-8B15-11ABB47B872B", "33E6DF69-BDFA-407A-9744-C175B60643AE", "Person Attribute", "PersonAttribute", "The Person attribute that contains the person that connection request should be created for.", 0, @"", "A360F5E8-EBE4-4F07-AC57-9521941C4A1A"); // Rock.Workflow.Action.CreateConnectionRequest:Person Attribute
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("70470236-7B36-4161-8B15-11ABB47B872B", "A75DFC58-7A1B-4799-BF31-451B2BBE38FF", "Order", "Order", "The order that this service should be used (priority)", 0, @"", "EB033986-7515-4C19-889D-88972D443AD8"); // Rock.Workflow.Action.CreateConnectionRequest:Order
            RockMigrationHelper.UpdateWorkflowActionEntityAttribute("70470236-7B36-4161-8B15-11ABB47B872B", "EC381D5D-729F-4581-A8F7-8C1FCE44DA98", "Connection Status", "ConnectionStatus", "The connection status to use for the new request (when Connection Status Attribute is not specified or invalid). If neither this setting or the Connection Status Attribute setting are set, the default status will be used.", 3, @"", "A7C730CD-799A-4434-87D5-23E7ABA27523"); // Rock.Workflow.Action.CreateConnectionRequest:Connection Status
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
            RockMigrationHelper.UpdateWorkflowType(false, true, "Text Homegroup Connection", "", "B22885AB-0DBD-4115-9484-626D795AC2CE", "Work", "fa fa-list-ol", 0, true, 0, "CA876138-0461-40AD-AB4F-67678B8BAECA"); // Text Homegroup Connection
            RockMigrationHelper.UpdateWorkflowTypeAttribute("CA876138-0461-40AD-AB4F-67678B8BAECA", "E4EAB7B2-0B76-429B-AFE4-AD86D7428C70", "FromPerson", "FromPerson", "", 0, @"57999151-81e4-4ecb-8643-431617278eb3", "73ADB593-81DA-4101-8C20-8FD98809A46D"); // Text Homegroup Connection:FromPerson
            RockMigrationHelper.UpdateWorkflowTypeAttribute("CA876138-0461-40AD-AB4F-67678B8BAECA", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPersonAttendanceCode", "FromPersonAttendanceCode", "", 1, @"", "06CE2574-72C1-4AF2-A1F8-00C877B94E5D"); // Text Homegroup Connection:FromPersonAttendanceCode
            RockMigrationHelper.UpdateWorkflowTypeAttribute("CA876138-0461-40AD-AB4F-67678B8BAECA", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPhone", "FromPhone", "", 2, @"+12086910479", "2D54EA70-1E6C-49FA-9C1C-AA1A9B139F72"); // Text Homegroup Connection:FromPhone
            RockMigrationHelper.UpdateWorkflowTypeAttribute("CA876138-0461-40AD-AB4F-67678B8BAECA", "9C204CD0-1233-41C5-818A-C5DA439445AA", "AttendanceKey", "AttendanceKey", "", 3, @"", "E367818F-8F87-44C6-9101-D318ABB963D8"); // Text Homegroup Connection:AttendanceKey
            RockMigrationHelper.UpdateWorkflowTypeAttribute("CA876138-0461-40AD-AB4F-67678B8BAECA", "9C204CD0-1233-41C5-818A-C5DA439445AA", "AttendanceCode", "AttendanceCode", "", 4, @"", "3B4D82D6-E457-49A8-ABA5-9F97FCBF03AE"); // Text Homegroup Connection:AttendanceCode
            RockMigrationHelper.UpdateWorkflowTypeAttribute("CA876138-0461-40AD-AB4F-67678B8BAECA", "9C204CD0-1233-41C5-818A-C5DA439445AA", "FromPersonFirstName", "FromPersonFirstName", "", 5, @"", "1974AC72-EBB7-4377-A1F4-86F7B89238AC"); // Text Homegroup Connection:FromPersonFirstName
            RockMigrationHelper.UpdateWorkflowTypeAttribute("CA876138-0461-40AD-AB4F-67678B8BAECA", "E4EAB7B2-0B76-429B-AFE4-AD86D7428C70", "Person", "Person", "", 6, @"", "FDDF1A6B-0EA6-405A-9EA6-207CC6EB306D"); // Text Homegroup Connection:Person
            RockMigrationHelper.UpdateWorkflowTypeAttribute("CA876138-0461-40AD-AB4F-67678B8BAECA", "B188B729-FE6D-498B-8871-65AB8FD1E11E", "ConnectionOpportunity", "ConnectionOpportunity", "", 7, @"2975D5C9-90F6-40B5-A795-5123AF9C9EFB", "5356E494-A0A6-420B-85E4-2780DFC5B12E"); // Text Homegroup Connection:ConnectionOpportunity
            RockMigrationHelper.UpdateWorkflowTypeAttribute("CA876138-0461-40AD-AB4F-67678B8BAECA", "1B71FEF4-201F-4D53-8C60-2DF21F1985ED", "Campus", "Campus", "", 8, @"", "8C4B3E60-5641-4D38-A64B-77804660DC98"); // Text Homegroup Connection:Campus
            RockMigrationHelper.UpdateWorkflowTypeAttribute("CA876138-0461-40AD-AB4F-67678B8BAECA", "73A4B6C6-502B-4E5B-BAA0-A85B7CCEC544", "ConnectionRequest", "ConnectionRequest", "", 9, @"", "CD2ADA9F-13A9-4D13-88D2-69CD33B41D90"); // Text Homegroup Connection:ConnectionRequest
            RockMigrationHelper.AddAttributeQualifier("06CE2574-72C1-4AF2-A1F8-00C877B94E5D", "ispassword", @"False", "399E16BA-8E26-4032-A950-B1984BBAE901"); // Text Homegroup Connection:FromPersonAttendanceCode:ispassword
            RockMigrationHelper.AddAttributeQualifier("2D54EA70-1E6C-49FA-9C1C-AA1A9B139F72", "ispassword", @"False", "2E609473-8302-4181-88BE-ED5C99916418"); // Text Homegroup Connection:FromPhone:ispassword
            RockMigrationHelper.AddAttributeQualifier("E367818F-8F87-44C6-9101-D318ABB963D8", "ispassword", @"False", "8B82BBDD-481D-4E8F-AC69-1B1DE26F7DAD"); // Text Homegroup Connection:AttendanceKey:ispassword
            RockMigrationHelper.AddAttributeQualifier("3B4D82D6-E457-49A8-ABA5-9F97FCBF03AE", "ispassword", @"False", "F3C0EECF-ABA2-4E27-B5D8-8D019F8EC1B4"); // Text Homegroup Connection:AttendanceCode:ispassword
            RockMigrationHelper.AddAttributeQualifier("1974AC72-EBB7-4377-A1F4-86F7B89238AC", "ispassword", @"False", "363AA246-B3FE-4715-BFA4-14113099BDAA"); // Text Homegroup Connection:FromPersonFirstName:ispassword
            RockMigrationHelper.UpdateWorkflowActivityType("CA876138-0461-40AD-AB4F-67678B8BAECA", true, "Validate Attendance Code", "validates a correct attendance code", true, 0, "1940FBA1-F073-4AA6-8563-8CE7D50BDE09"); // Text Homegroup Connection:Validate Attendance Code
            RockMigrationHelper.UpdateWorkflowActivityType("CA876138-0461-40AD-AB4F-67678B8BAECA", true, "Submit Group Connection", "", false, 1, "25827A7B-9C02-469C-904E-E9F29AEC5670"); // Text Homegroup Connection:Submit Group Connection
            RockMigrationHelper.UpdateWorkflowActionType("1940FBA1-F073-4AA6-8563-8CE7D50BDE09", "Activate Check In", 2, "38907A90-1634-4A93-8017-619326A4A582", true, false, "", "3B4D82D6-E457-49A8-ABA5-9F97FCBF03AE", 64, "", "325E0221-D26F-4814-B849-911FD64AC27B"); // Text Homegroup Connection:Validate Attendance Code:Activate Check In
            RockMigrationHelper.UpdateWorkflowActionType("25827A7B-9C02-469C-904E-E9F29AEC5670", "Send SMS Response", 2, "F22FA171-B5E7-497F-9AE6-F7B98A377D0E", true, false, "", "", 1, "", "193068D5-62E6-45A7-8783-061158877477"); // Text Homegroup Connection:Submit Group Connection:Send SMS Response
            RockMigrationHelper.UpdateWorkflowActionType("25827A7B-9C02-469C-904E-E9F29AEC5670", "Get First name", 0, "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", true, false, "", "", 1, "", "7B862070-5456-4075-8B41-8855077CAD2D"); // Text Homegroup Connection:Submit Group Connection:Get First name
            RockMigrationHelper.UpdateWorkflowActionType("1940FBA1-F073-4AA6-8563-8CE7D50BDE09", "get Attendance Code from Person", 0, "85D1DBFE-9F3F-486A-BF2C-60146A8D97F8", true, false, "", "", 1, "", "66C9E4BD-FCB3-47E5-AA2C-3A1CFA1F48EF"); // Text Homegroup Connection:Validate Attendance Code:get Attendance Code from Person
            RockMigrationHelper.UpdateWorkflowActionType("25827A7B-9C02-469C-904E-E9F29AEC5670", "Submit Connection Request", 1, "70470236-7B36-4161-8B15-11ABB47B872B", true, false, "", "", 1, "", "52FA586C-E1DD-4667-B0E2-9726065FAF20"); // Text Homegroup Connection:Submit Group Connection:Submit Connection Request
            RockMigrationHelper.UpdateWorkflowActionType("1940FBA1-F073-4AA6-8563-8CE7D50BDE09", "Validate Code", 1, "550458E4-BBBF-4E47-955E-1DBE79352E7D", true, false, "", "", 1, "", "6DACD2A8-C73C-4EC6-9D71-B5887568AAE4"); // Text Homegroup Connection:Validate Attendance Code:Validate Code
            RockMigrationHelper.AddActionTypeAttributeValue("66C9E4BD-FCB3-47E5-AA2C-3A1CFA1F48EF", "CF19BB9A-EA5B-43E5-89A1-FA416F430761", @"73adb593-81da-4101-8c20-8fd98809a46d"); // Text Homegroup Connection:Validate Attendance Code:get Attendance Code from Person:PersonAttribute
            RockMigrationHelper.AddActionTypeAttributeValue("66C9E4BD-FCB3-47E5-AA2C-3A1CFA1F48EF", "40FF47A2-9682-4545-BDF3-171B5F6B8A5C", @"06ce2574-72c1-4af2-a1f8-00c877b94e5d"); // Text Homegroup Connection:Validate Attendance Code:get Attendance Code from Person:Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("66C9E4BD-FCB3-47E5-AA2C-3A1CFA1F48EF", "52930E88-A86E-47AE-BB1D-9937692BBF74", @"{{ Person.LastAttendanceCode }}"); // Text Homegroup Connection:Validate Attendance Code:get Attendance Code from Person:Lava
            RockMigrationHelper.AddActionTypeAttributeValue("66C9E4BD-FCB3-47E5-AA2C-3A1CFA1F48EF", "E7527DBD-32B1-47CE-8D22-142EDE32BD7D", @""); // Text Homegroup Connection:Validate Attendance Code:get Attendance Code from Person:Order
            RockMigrationHelper.AddActionTypeAttributeValue("66C9E4BD-FCB3-47E5-AA2C-3A1CFA1F48EF", "8DE0F372-4B1C-4612-B318-E598E4CC17F8", @"False"); // Text Homegroup Connection:Validate Attendance Code:get Attendance Code from Person:Active
            RockMigrationHelper.AddActionTypeAttributeValue("6DACD2A8-C73C-4EC6-9D71-B5887568AAE4", "0FC7338D-F75D-401F-8F03-ADDA92315A3B", @"{{Workflow.FromPersonAttendanceCode}}"); // Text Homegroup Connection:Validate Attendance Code:Validate Code:UserInputCode
            RockMigrationHelper.AddActionTypeAttributeValue("6DACD2A8-C73C-4EC6-9D71-B5887568AAE4", "18BA2FE7-7620-42CE-8FD8-727A26683B81", @""); // Text Homegroup Connection:Validate Attendance Code:Validate Code:Order
            RockMigrationHelper.AddActionTypeAttributeValue("6DACD2A8-C73C-4EC6-9D71-B5887568AAE4", "C9FC261D-84BF-41F7-9636-734EAAF0FD86", @"False"); // Text Homegroup Connection:Validate Attendance Code:Validate Code:Active
            RockMigrationHelper.AddActionTypeAttributeValue("325E0221-D26F-4814-B849-911FD64AC27B", "E8ABD802-372C-47BE-82B1-96F50DB5169E", @"False"); // Text Homegroup Connection:Validate Attendance Code:Activate Check In:Active
            RockMigrationHelper.AddActionTypeAttributeValue("325E0221-D26F-4814-B849-911FD64AC27B", "3809A78C-B773-440C-8E3F-A8E81D0DAE08", @""); // Text Homegroup Connection:Validate Attendance Code:Activate Check In:Order
            RockMigrationHelper.AddActionTypeAttributeValue("325E0221-D26F-4814-B849-911FD64AC27B", "02D5A7A5-8781-46B4-B9FC-AF816829D240", @"25827A7B-9C02-469C-904E-E9F29AEC5670"); // Text Homegroup Connection:Validate Attendance Code:Activate Check In:Activity
            RockMigrationHelper.AddActionTypeAttributeValue("7B862070-5456-4075-8B41-8855077CAD2D", "CF19BB9A-EA5B-43E5-89A1-FA416F430761", @"73adb593-81da-4101-8c20-8fd98809a46d"); // Text Homegroup Connection:Submit Group Connection:Get First name:PersonAttribute
            RockMigrationHelper.AddActionTypeAttributeValue("7B862070-5456-4075-8B41-8855077CAD2D", "40FF47A2-9682-4545-BDF3-171B5F6B8A5C", @"1974ac72-ebb7-4377-a1f4-86f7b89238ac"); // Text Homegroup Connection:Submit Group Connection:Get First name:Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("7B862070-5456-4075-8B41-8855077CAD2D", "52930E88-A86E-47AE-BB1D-9937692BBF74", @"{{Person.FirstName}}"); // Text Homegroup Connection:Submit Group Connection:Get First name:Lava
            RockMigrationHelper.AddActionTypeAttributeValue("7B862070-5456-4075-8B41-8855077CAD2D", "E7527DBD-32B1-47CE-8D22-142EDE32BD7D", @""); // Text Homegroup Connection:Submit Group Connection:Get First name:Order
            RockMigrationHelper.AddActionTypeAttributeValue("7B862070-5456-4075-8B41-8855077CAD2D", "8DE0F372-4B1C-4612-B318-E598E4CC17F8", @"False"); // Text Homegroup Connection:Submit Group Connection:Get First name:Active
            RockMigrationHelper.AddActionTypeAttributeValue("52FA586C-E1DD-4667-B0E2-9726065FAF20", "EB033986-7515-4C19-889D-88972D443AD8", @""); // Text Homegroup Connection:Submit Group Connection:Submit Connection Request:Order
            RockMigrationHelper.AddActionTypeAttributeValue("52FA586C-E1DD-4667-B0E2-9726065FAF20", "F866CF22-D18F-4759-9051-94A853F6EA43", @"False"); // Text Homegroup Connection:Submit Group Connection:Submit Connection Request:Active
            RockMigrationHelper.AddActionTypeAttributeValue("52FA586C-E1DD-4667-B0E2-9726065FAF20", "A360F5E8-EBE4-4F07-AC57-9521941C4A1A", @"73adb593-81da-4101-8c20-8fd98809a46d"); // Text Homegroup Connection:Submit Group Connection:Submit Connection Request:Person Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("52FA586C-E1DD-4667-B0E2-9726065FAF20", "0EA48DF4-A65C-4FD3-9475-5E72021D51D4", @"5356e494-a0a6-420b-85e4-2780dfc5b12e"); // Text Homegroup Connection:Submit Group Connection:Submit Connection Request:Connection Opportunity Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("52FA586C-E1DD-4667-B0E2-9726065FAF20", "DB13FD7B-7AA4-4D6F-9146-ABF68D9AEFAB", @""); // Text Homegroup Connection:Submit Group Connection:Submit Connection Request:Connection Status Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("52FA586C-E1DD-4667-B0E2-9726065FAF20", "A7C730CD-799A-4434-87D5-23E7ABA27523", @""); // Text Homegroup Connection:Submit Group Connection:Submit Connection Request:Connection Status
            RockMigrationHelper.AddActionTypeAttributeValue("52FA586C-E1DD-4667-B0E2-9726065FAF20", "EC54AF83-6AD5-4A77-98EA-97FAABA83794", @"8c4b3e60-5641-4d38-a64b-77804660dc98"); // Text Homegroup Connection:Submit Group Connection:Submit Connection Request:Campus Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("52FA586C-E1DD-4667-B0E2-9726065FAF20", "295264F8-0EEF-4D87-A874-AD72EF8BFEB9", @"cd2ada9f-13a9-4d13-88d2-69cd33b41d90"); // Text Homegroup Connection:Submit Group Connection:Submit Connection Request:Connection Request Attribute
            RockMigrationHelper.AddActionTypeAttributeValue("193068D5-62E6-45A7-8783-061158877477", "ED73C139-0EC5-4360-8345-8D42B2F8C855", @"42eddbfb-fdc8-4b23-9b15-4a0f8c5cde93"); // Text Homegroup Connection:Submit Group Connection:Send SMS Response:From
            RockMigrationHelper.AddActionTypeAttributeValue("193068D5-62E6-45A7-8783-061158877477", "C34E2D58-D2D0-48D7-8BBC-2973C5D2B03A", @""); // Text Homegroup Connection:Submit Group Connection:Send SMS Response:Order
            RockMigrationHelper.AddActionTypeAttributeValue("193068D5-62E6-45A7-8783-061158877477", "53C5F522-B968-4D7E-8BEE-26E49575B601", @"False"); // Text Homegroup Connection:Submit Group Connection:Send SMS Response:Active
            RockMigrationHelper.AddActionTypeAttributeValue("193068D5-62E6-45A7-8783-061158877477", "FB5DCFBE-31A0-4259-8DD1-DFCDDF709A5D", @"2d54ea70-1e6c-49fa-9c1c-aa1a9b139f72"); // Text Homegroup Connection:Submit Group Connection:Send SMS Response:Recipient|Attribute Value
            RockMigrationHelper.AddActionTypeAttributeValue("193068D5-62E6-45A7-8783-061158877477", "7943EBA0-6ADB-4127-BD3C-E5AF4C75BBC9", @"Thank you {{ Workflow.FromPersonFirstName }} for wanting to get connected. We will contact you this next week."); // Text Homegroup Connection:Submit Group Connection:Send SMS Response:Message|Attribute Value
        }
    }
}
