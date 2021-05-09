//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct ImportScopeRow : ICliRecord<ImportScopeRow,ImportScope>
        {
            public CliRowKey<ImportScope> Key;

            public BlobIndex Imports;
        }
    }
}