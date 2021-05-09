//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct CliStreamHeader : IRecord<CliStreamHeader>
    {
        public Address32 Offset;

        public uint StreamSize;

        public string Name;
    }
}