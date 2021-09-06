//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        public struct kvp<S,T>
            where S : unmanaged
            where T : unmanaged
        {
            public S Key;

            public T Val;

            [MethodImpl(Inline)]
            public kvp(S src, T dst)
            {
                Key =src;
                Val = dst;
            }

            public string Format()
                => Render.format(this);

            public override string ToString()
                => Format();

            public static implicit operator kvp<S,T>((S src, T dst) x)
                => new kvp<S,T>(x.src, x.dst);
        }
    }
}