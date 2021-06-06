//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public unsafe readonly struct StackExtents
    {
        public MemoryAddress BaseAddress {get;}

        public ByteSize Size {get;}

        [MethodImpl(Inline)]
        public StackExtents(MemoryAddress @base, ulong size)
        {
            BaseAddress = @base;
            Size = size;
        }
    }
}