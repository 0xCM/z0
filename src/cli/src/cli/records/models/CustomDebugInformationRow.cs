//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.CustomDebugInformation), StructLayout(LayoutKind.Sequential)]
        public struct CustomDebugInformationRow : ICliRecord<CustomDebugInformationRow>
        {
            public CliRowKey Parent;

            public GuidIndex Kind;

            public BlobIndex Value;
        }
    }
}