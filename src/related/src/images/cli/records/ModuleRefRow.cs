//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [Record(CliTableKind.ModuleRef),  StructLayout(LayoutKind.Sequential)]
        public struct ModuleRefRow : IRecord<ModuleRefRow>
        {
            public RowKey Key;

            public StringIndex Name;
        }
    }
}