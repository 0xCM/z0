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
        public struct ModuleRow : ICliRecord<ModuleRow,Module>
        {
            public CliRowKey<Module> Key;

            public ushort Generation;

            public StringIndex Name;

            public GuidIndex ModuleVersionId;

            public GuidIndex EncId;

            public GuidIndex EncBaseId;
        }
    }
}