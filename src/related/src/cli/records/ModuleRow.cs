//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.Module), StructLayout(LayoutKind.Sequential)]
        public struct ModuleRow : ICliRecord<ModuleRow>
        {
            public CliRowKey Key;

            public ushort Generation;

            public StringIndex Name;

            public GuidIndex ModuleVersionId;

            public GuidIndex EncId;

            public GuidIndex EncBaseId;
        }
    }
}