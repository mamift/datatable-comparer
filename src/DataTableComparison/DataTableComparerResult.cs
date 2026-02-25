using PrimitiveExtensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DataTableComparison
{
    /// <summary>
    /// Helper class to compare multiple data tables
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class DataTableComparerResult
    {
        public DataTableComparer DataTableComparer { get; internal set; }
        public DataTable ResultsDataTable { get; internal set; }
        public bool AllTablesContainTheSamePrimaryKeysRows()
        {
            return !ResultsDataTable.Select($"[{DataTableComparer.Config.ExistsInColumnNamePrefix}{DataTableComparer.Config.WordSeperator}Status] = '{DataTableComparer.Config.OutOfSyncPhrase}'").Any();
        }

        public DataTableComparerResult(DataTableComparer dataTableComparer)
        {
            DataTableComparer = dataTableComparer;
        }
    }
}
