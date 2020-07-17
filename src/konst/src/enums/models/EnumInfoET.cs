//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EnumInfo<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        public ArtifactIdentity Id {get;}
        
        public uint Position {get;}
        
        public string Name {get;}

        public E Literal {get;}

        public T Scalar {get;}

        [MethodImpl(Inline)]
        public EnumInfo(ArtifactIdentity id, uint index, string name, E literal, T scalar)
        {
            Id = id;
            Position = index;
            Name = name;
            Literal = literal;
            Scalar = scalar;
        }                
    }
}