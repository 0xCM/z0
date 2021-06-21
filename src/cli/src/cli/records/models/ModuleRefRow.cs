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
        [CliRecord(CliTableKind.ModuleRef), StructLayout(LayoutKind.Sequential)]
        public struct ModuleRefRow : ICliRecord<ModuleRefRow>
        {
            public CliStringIndex Name;
        }
    }
}