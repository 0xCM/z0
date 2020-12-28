//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EnumLiteralInfo<E,P>
        where E : unmanaged, Enum
        where P : unmanaged
    {
        public ClrToken Token {get;}

        public uint Position {get;}

        public string Name {get;}

        public E Literal {get;}

        public P Scalar {get;}

        [MethodImpl(Inline)]
        public EnumLiteralInfo(ClrToken id, uint index, string name, E literal, P scalar)
        {
            Token = id;
            Position = index;
            Name = name;
            Literal = literal;
            Scalar = scalar;
        }
    }
}