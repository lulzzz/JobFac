﻿
namespace JobFac.database
{
    public static class ConstQueries
    {
        public static readonly string SelectJobDefinition = "SELECT * FROM JobDefinition WHERE Id = @Id;";
        public static readonly string SelectSequenceDefinition = "SELECT * FROM SequenceDefinition WHERE Id = @Id;";
        public static readonly string SelectSequenceSteps = "SELECT * FROM StepDefinition WHERE SequenceId = @Id ORDER BY Step;";

        public static readonly string SelectJobHistory = "SELECT * FROM JobHistory WHERE InstanceKey = @InstanceKey;";
        public static readonly string SelectSequenceHistory = "SELECT * FROM SequenceHistory WHERE InstanceKey = @InstanceKey;";

        public static readonly string SelectJobHistoryAfter = "SELECT * FROM JobHistory WHERE DefinitionId = @DefinitionId AND LastUpdated >= @FromDate;";
        public static readonly string SelectSequenceHistoryAfter = "SELECT * FROM SequenceHistory WHERE DefinitionId = @DefinitionId AND LastUpdated >= @FromDate;";

        public static readonly string SelectJobHistoryBetween = "SELECT * FROM JobHistory WHERE DefinitionId = @DefinitionId AND LastUpdated BETWEEN @FirstDate AND @LastDate;";
        public static readonly string SelectSequenceHistoryBetween = "SELECT * FROM SequenceHistory WHERE DefinitionId = @DefinitionId AND LastUpdated BETWEEN @FirstDate AND @LastDate;";

        public static readonly string PurgeHistory = "DELETE FROM JobHistory WHERE DeleteAfter < @Now; DELETE FROM SequenceHistory WHERE DeleteAfter < @Now;";

        public static readonly string InsertJobHistory = @"INSERT INTO JobHistory 
        (InstanceKey, DefinitionId, LastUpdated, DeleteAfter, FinalRunStatus, ExitCode, FullDetailsJson)
        VALUES (@InstanceKey, @DefinitionId, @LastUpdated, @DeleteAfter, @FinalRunStatus, @ExitCode, @FullDetailsJson);";

        public static readonly string InsertSequenceHistory = @"INSERT INTO SequenceHistory 
        (InstanceKey, DefinitionId, LastUpdated, DeleteAfter, FinalRunStatus, FullDetailsJson)
        VALUES (@InstanceKey, @DefinitionId, @LastUpdated, @DeleteAfter, @FinalRunStatus, @FullDetailsJson);";

        public static readonly string UpdateJobHistory = @"UPDATE JobHistory SET
        InstanceKey = @InstanceKey, DefinitionId = @DefinitionId, LastUpdated = @LastUpdated, 
        DeleteAfter = @DeleteAfter, FinalRunStatus = @FinalRunStatus, ExitCode = @ExitCode, FullDetailsJson = @FullDetailsJson;";

        public static readonly string UpdateSequenceHistory = @"UPDATE SequenceHistory SET
        InstanceKey = @InstanceKey, DefinitionId = @DefinitionId, LastUpdated = @LastUpdated, 
        DeleteAfter = @DeleteAfter, FinalRunStatus = @FinalRunStatus, FullDetailsJson = @FullDetailsJson;";
    }
}
