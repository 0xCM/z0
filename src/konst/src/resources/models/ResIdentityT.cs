//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    public readonly struct ResIdentity<T>
        where T : unmanaged
    {
        public readonly asci32 Name;

        public readonly MemRef Reference;

        [MethodImpl(Inline)]
        public static implicit operator ResIdentity(ResIdentity<T> src)
            => new ResIdentity(src.Name,src.Reference, primal<T>());

        [MethodImpl(Inline)]
        public ResIdentity(in asci32 name, in MemRef memref)
        {
            Name = name;
            Reference = memref;            
        }

        public MemoryAddress Address 
        {
            [MethodImpl(Inline)]
            get => Reference.Address;
        }

        public uint CellCount 
        {
            [MethodImpl(Inline)]
            get => DataSize/CellSize;
        }

        public uint CellSize 
        {
            [MethodImpl(Inline)]
            get => (uint)size<T>();
        }

        public uint DataSize 
        {
            [MethodImpl(Inline)]
            get => Reference.DataSize;
        }
    }
}