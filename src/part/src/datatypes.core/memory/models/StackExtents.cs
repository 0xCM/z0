//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public unsafe readonly struct StackExtents
    {
        public byte* BaseAddress {get;}

        public ulong Size {get;}

        [MethodImpl(Inline)]
        public StackExtents(byte* @base, ulong size)
        {
            BaseAddress = @base;
            Size = size;
        }
    }
}