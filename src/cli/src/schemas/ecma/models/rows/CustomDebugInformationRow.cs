//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record(CliTableKind.CustomDebugInformation), StructLayout(LayoutKind.Sequential)]
    public struct CustomDebugInformationRow : IRecord<CustomDebugInformationRow>
    {
        public RowKey Key;

        public RowKey Parent;

        public GuidIndex Kind;

        public BlobIndex Value;
    }
}