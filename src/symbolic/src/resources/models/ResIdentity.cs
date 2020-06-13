//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ResIdentity
    {
        [MethodImpl(Inline)]
        public static ResIdentity Define(string name, MemoryRef memref, PrimalKind type)
            => new ResIdentity(name, memref, type);

        [MethodImpl(Inline)]
        public static ResIdentity<T> Define<T>(string name, ulong location, int length)
            where T : unmanaged
                => new ResIdentity<T>(name,location,length);
        
        [MethodImpl(Inline)]
        public ResIdentity(string name, MemoryRef memref, PrimalKind type)
        {
            Name = name;
            Reference = memref;
            DataType = type;
        }

        public string Name {get;}

        public MemoryRef Reference {get;}
        
        public PrimalKind DataType {get;}
        
        public int CellCount  
            => Reference.Length;

        public MemoryAddress Address
            => Reference.Address;
    }
}