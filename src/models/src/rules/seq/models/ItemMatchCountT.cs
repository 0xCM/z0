//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using api = SeqRules;

    partial struct SeqRules
    {
        public readonly struct ItemMatchCount<T> : ITerm<T>
            where T : IEquatable<T>
        {
            public ItemMatch<T> Match {get;}

            [MethodImpl(Inline)]
            public ItemMatchCount(ItemMatch<T> match)
            {
                Match = match;
            }

            public string Format()
                => SeqRules.format(this);


            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator ItemMatchCount<T>(T src)
                => new ItemMatchCount<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator ItemMatchCount<T>(ItemMatch<T> src)
                => new ItemMatchCount<T>(src);
        }
    }
}