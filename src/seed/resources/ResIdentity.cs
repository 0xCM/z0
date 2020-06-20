//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    public readonly struct ResIdentity
    {
        public string Name {get;}

        public MemRef Reference {get;}
        
        public PrimalKind DataType {get;}

        [MethodImpl(Inline)]
        public static ResIdentity<T> Define<T>(string name, ulong location, int length)
            where T : unmanaged
                => new ResIdentity<T>(name, memref(location, length));
        
        [MethodImpl(Inline)]
        public ResIdentity(string name, MemRef memref, PrimalKind type)
        {
            Name = name;
            Reference = memref;
            DataType = type;
        }    
    }
}