//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    public readonly struct @enum<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        public MetadataToken Token {get;}
        
        public int Index {get;}
        
        public string Name {get;}

        public E Literal {get;}

        public T Scalar {get;}

        [MethodImpl(Inline)]
        public @enum(MetadataToken token, int index, string name, E literal, T scalar)
        {
            Token = token;
            Index = index;
            Name = name;
            Literal = literal;
            Scalar = scalar;
        }                
    }
}