//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), Record]
    public struct ImageBaseRelocation : IRecord<ImageBaseRelocation>
    {
        public uint VirtualAddress;

        public uint SizeOfBlock;
    }
}