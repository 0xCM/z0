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
        public asci32 Name {get;}

        public MemRef Reference {get;}
        
        public PrimalKind DataType {get;}
        
        [MethodImpl(Inline)]
        public ResIdentity(asci32 name, MemRef memref, PrimalKind type)
        {
            Name = name;
            Reference = memref;
            DataType = type;
        }    
    }
}