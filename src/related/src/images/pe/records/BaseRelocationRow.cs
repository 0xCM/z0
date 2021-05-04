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
        [Record, StructLayout(LayoutKind.Sequential)]
        public struct BaseRelocationRow : IRecord<BaseRelocationRow>
        {
            public Address32 VirtualAddress;

            public uint SizeOfBlock;
        }
    }
}