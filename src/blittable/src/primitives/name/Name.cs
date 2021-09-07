//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        public readonly struct Name
        {
            readonly StringAddress<N64> Value;

            [MethodImpl(Inline)]
            public Name(StringAddress<N64> src)
            {
                Value = src;
            }

            public string Format()
                => Value.Format();

            public override string ToString()

                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Name(StringAddress<N64> src)
                => new Name(src);

            [MethodImpl(Inline)]
            public static implicit operator Name(string src)
                => new Name(src);
        }
    }
}
