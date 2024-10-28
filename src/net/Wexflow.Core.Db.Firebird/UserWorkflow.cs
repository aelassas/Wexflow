﻿namespace Wexflow.Core.Db.Firebird
{
    public class UserWorkflow : Core.Db.UserWorkflow
    {
        public const string COLUMN_NAME_ID = "ID";
        public const string COLUMN_NAME_USER_ID = "USER_ID";
        public const string COLUMN_NAME_WORKFLOW_ID = "WORKFLOW_ID";

        public const string TABLE_STRUCT = "(" + COLUMN_NAME_ID + " integer generated by default as identity primary key, " + COLUMN_NAME_USER_ID + " INTEGER, " + COLUMN_NAME_WORKFLOW_ID + " INTEGER)";

        public string Id { get; set; }
    }
}