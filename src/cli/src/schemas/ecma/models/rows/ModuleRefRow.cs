//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record(CliTableKind.ModuleRef),  StructLayout(LayoutKind.Sequential)]
    public struct ModuleRefRow : IRecord<ModuleRefRow>
    {
        public RowKey Key;

        public StringIndex Name;
    }
}