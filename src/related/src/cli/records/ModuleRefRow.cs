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
        public struct ModuleRefRow : ICliRecord<ModuleRefRow,ModuleRef>
        {
            public CliRowKey<ModuleRef> Key;

            public StringIndex Name;
        }
    }
}