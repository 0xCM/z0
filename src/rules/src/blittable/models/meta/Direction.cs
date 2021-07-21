//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Blit
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Direction
    {
        public DirectionKind Kind {get;}

        [MethodImpl(Inline)]
        public Direction(DirectionKind kind)
        {
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public static implicit operator Direction(DirectionKind src)
            => new Direction(src);

        [MethodImpl(Inline)]
        public static implicit operator DirectionKind(Direction src)
            => src.Kind;
    }
}