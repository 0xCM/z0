//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(CliTableKind.InterfaceImpl), StructLayout(LayoutKind.Sequential)]
        public struct InterfaceImplRow : IRecord<InterfaceImplRow>
        {
            public RowKey Key;

            public RowKey Class;

            public RowKey Interface;
        }
    }
}