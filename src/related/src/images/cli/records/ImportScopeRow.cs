//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [Record(CliTableKind.ImportScope), StructLayout(LayoutKind.Sequential)]
        public struct ImportScopeRow
        {
            public RowKey Parent;

            public BlobIndex Imports;
        }
    }
}