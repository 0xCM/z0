//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.InterfaceImpl), StructLayout(LayoutKind.Sequential)]
        public struct InterfaceImplRow : ICliRecord<InterfaceImplRow>
        {
            public CliRowKey Key;

            public CliRowKey Class;

            public CliRowKey Interface;
        }
    }
}