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
        public readonly struct ItemMatch<T> : ITerm<T>
            where T : IEquatable<T>
        {
            public T Value {get;}

            [MethodImpl(Inline)]
            public ItemMatch(T match)
            {
                Value = match;
            }

            public string Format()
                => SeqRules.format(this);


            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator ItemMatch<T>(T src)
                => new ItemMatch<T>(src);
        }
    }
}