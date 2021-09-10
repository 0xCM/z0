//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct BitFlow
    {
        public readonly struct Direction
        {
            public ParamDirection Kind {get;}

            [MethodImpl(Inline)]
            public Direction(ParamDirection kind)
            {
                Kind = kind;
            }

            [MethodImpl(Inline)]
            public static implicit operator Direction(ParamDirection src)
                => new Direction(src);

            [MethodImpl(Inline)]
            public static implicit operator ParamDirection(Direction src)
                => src.Kind;
        }
    }
}