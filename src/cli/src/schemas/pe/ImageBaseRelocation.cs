//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Pe
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), Record]
    public struct ImageBaseRelocation : IRecord<ImageBaseRelocation>
    {
        public Address32 VirtualAddress;

        public uint SizeOfBlock;
    }
}