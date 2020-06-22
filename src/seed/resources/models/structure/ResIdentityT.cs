//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Konst;

    public readonly struct ResIdentity<T>
        where T : unmanaged
    {
        public asci32 Name {get;}

        public MemRef Reference {get;}

        [MethodImpl(Inline)]
        public static implicit operator ResIdentity(ResIdentity<T> src)
            => new ResIdentity(src.Name,src.Reference, Root.primal<T>());

        [MethodImpl(Inline)]
        public ResIdentity(asci32 name, MemRef memref)
        {
            Name = name;
            Reference = memref;            
        }

        public MemoryAddress Location 
        {
            [MethodImpl(Inline)]
            get => Reference.Address;
        }

        public int CellCount 
        {
            [MethodImpl(Inline)]
            get => ByteCount/CellSize;
        }

        public int CellSize 
        {
            [MethodImpl(Inline)]
            get => size<T>();
        }

        public ByteSize ByteCount 
        {
            [MethodImpl(Inline)]
            get => Reference.Length;
        }
    }
}