//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record, StructLayout(LayoutKind.Sequential)]
        public struct StreamHeader : IRecord<StreamHeader>
        {
            public Address32 Offset;

            public uint StreamSize;

            public string Name;
        }
    }
}