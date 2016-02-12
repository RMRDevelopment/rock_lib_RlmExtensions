﻿using Rock.Plugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.reallifeministries.RockExtensions.Migrations
{
    [MigrationNumber(16, "1.2.0")]
    class _014_DefinedTypesForTextAttendance : Migration
    {
        Guid guidTHIRST = Guid.NewGuid();
        Guid guidOption1 = Guid.NewGuid();
        Guid guidOption2 = Guid.NewGuid();
        Guid guidOption3 = Guid.NewGuid();
        Guid guidOption4 = Guid.NewGuid();
        Guid guidOption5 = Guid.NewGuid();
        Guid guidOptionPR = Guid.NewGuid();
        static string rlmTHIRSTCampusGuid = "84BE9A09-9E7D-4875-A3F9-C8949BC023BA";
        static string rlmTHIRSTAttendanceGroupGuid = "B47ED326-EB99-4A31-9E80-BA91B905B5E6";
        static string thirstPhone = "+12082157755";
        public override void Down()
        {
            RockMigrationHelper.DeleteDefinedValue(guidOption1.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidOption2.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidOption3.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidOption4.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidOption5.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidOptionPR.ToString());
            RockMigrationHelper.DeleteDefinedValue(guidTHIRST.ToString());
        }                                                                                                   

        public override void Up()
        {            
            // THIRST Campus Defined Values
            
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", thirstPhone, "THIRST - thirst####", guidTHIRST.ToString(), false);
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", thirstPhone, "THIRST: Text in Attendance Option (1) - Check in Household", guidOption1.ToString(), false);            
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", thirstPhone, "THIRST: Text Attendance Option (2) - Prayer Request", guidOption2.ToString(), false);
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", thirstPhone, "THIRST - Text Attendance Option (3) - Join a Homegroup", guidOption3.ToString(), false);
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", thirstPhone, "THIRST: Text Attendance Option (4) - Review Contact Info", guidOption4.ToString(), false);            
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", thirstPhone, "THIRST: Text Attendance Option (5) - Remove Last Attendance", guidOption5.ToString(), false);            
            RockMigrationHelper.AddDefinedValue("2CACB86F-D811-4483-98E1-272F1FF8FF5D", thirstPhone, "THIRST: Text Attendance Prayer Request Final", guidOptionPR.ToString(), false);
            
            RockMigrationHelper.AddDefinedValueAttributeValue(guidTHIRST.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"d8354ea7-7da9-449d-94ee-210c6b9496d8");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidTHIRST.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmTHIRSTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidTHIRST.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"(?i)thirst[0-9]...");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidTHIRST.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"THIRST Message from: {{ FromPerson.FullName }}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidTHIRST.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmTHIRSTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidTHIRST.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{ FromPhone }}|ReceivedDateTime^{{ ReceivedDateTime}}|MessageBody^{{ MessageBody }}|ReceivedDate^{{ReceivedDate}}|ReceivedTime^{{ReceivedTime}}|Campus^Coeur d'Alene Campus|AttendanceGroup^RLM THIRST Weekend Worship|");

            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption1.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"c5fe671a-c3ca-4785-95dd-3cb10f4308b0");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption1.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmTHIRSTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption1.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^1.*");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption1.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"Thirst Message From: {{ FromPerson.FullName}}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption1.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmTHIRSTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption1.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|ReceivedDateTime^{{ReceivedDateTime}}|Campus^Coeur d'Alene Campus|AttendanceGroup^RLM THIRST Weekend Worship|");

            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"8722ac70-d178-4306-bf91-eb2fbb11dfa2");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmTHIRSTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^2$");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"Thirst Message From: {{ FromPerson.FullName}}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmTHIRSTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption2.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|ReceivedDateTime^{{ReceivedDateTime}}|MessageBody^{{MessageBody}}|");

            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"88978527-0ca4-4c52-8fda-cf915fafa472");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmTHIRSTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^2.+");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"Thirst: Prayer Request from {{ FromPerson.FullName }}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmTHIRSTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOptionPR.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|MessageBody^{{MessageBody}}|");

            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"ca876138-0461-40ad-ab4f-67678b8baeca");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmTHIRSTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^3.*");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"Thirst: Message for Joining a homegroup from {{ FromPerson.FullName}}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmTHIRSTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption3.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|ReceivedDateTime^{{ ReceivedDateTime }}|Campus^Coeur d'Alene Campus|");

            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"feb34437-9600-4330-855f-85404ec10018");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmTHIRSTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^4.*");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"Thirst Message From: {{ FromPerson.FullName}}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmTHIRSTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption4.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|ReceivedDateTime^{{ReceivedDateTime}}|MessageBody^{{MessageBody}}|");

            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "0097D00F-1F29-4217-8E67-D37A619A6FA3", @"a74396b8-4723-4be7-9f4a-14506c921fc8");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "17B0E99E-2D10-442A-9342-1F9F07996C2B", rlmTHIRSTAttendanceGroupGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "3A526D6C-06FC-46CD-A447-9A6D9A74BB4F", @"^5.*");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "67E09C64-3558-48B7-9A27-A9499D0826E8", @"Thirst Message From: {{ FromPerson.FullName}}");
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "79E3B97B-A717-45AB-A279-335FCDEA141A", rlmTHIRSTCampusGuid);
            RockMigrationHelper.AddDefinedValueAttributeValue(guidOption5.ToString(), "836CFC0B-6750-4A93-8309-EAB868B845AF", @"FromPhone^{{FromPhone}}|ReceivedDateTime^{{ReceivedDateTime}}|MessageBody^{{MessageBody}}|");

        }
    }
}
