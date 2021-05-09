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
        [Record(CliTableKind.ModuleRef),  StructLayout(LayoutKind.Sequential)]
        public struct ModuleRefRow : ICliRecord<ModuleRefRow>
        {
            public CliRowKey<ModuleRef> Key;

            public StringIndex Name;
        }
    }
}