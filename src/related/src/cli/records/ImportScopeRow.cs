//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.ImportScope), StructLayout(LayoutKind.Sequential)]
        public struct ImportScopeRow : ICliRecord<ImportScopeRow>
        {
            public CliRowKey Parent;

            public BlobIndex Imports;
        }
    }
}