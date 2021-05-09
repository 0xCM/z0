//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct InterfaceImplRow : ICliRecord<InterfaceImplRow,InterfaceImpl>
        {
            public CliRowKey<InterfaceImpl> Key;

            public CliRowKey Class;

            public CliRowKey Interface;
        }
    }
}