//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public class AddressSpace
    {
        public MemoryAddress Base {get;}

        public MemoryAddress Offset {get;}

        public MemoryScale Scale {get;}

        [MethodImpl(Inline)]
        public AddressSpace(MemoryAddress @base, MemoryAddress offset, MemoryScale scale)
        {
            Base = @base;
            Offset = offset;
            Scale = scale;
        }
    }
}