//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct CustomDebugInformationRow : ICliRecord<CustomDebugInformationRow, CustomDebugInformation>
        {
            public CliRowKey<CustomDebugInformation> Key;

            public CliRowKey Parent;

            public GuidIndex Kind;

            public BlobIndex Value;
        }
    }
}