//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [DataType]
    public readonly struct Meaning : IMeaning<Meaning,object>
    {
        public object Content {get;}

        [MethodImpl(Inline)]
        public static Meaning Attributed(Type src)
            => new Meaning(MeaningAttribute.ContentValue(src));

        [MethodImpl(Inline)]
        public static implicit operator string(Meaning src)
            => src.Content?.ToString() ?? EmptyString;

        [MethodImpl(Inline)]
        public static implicit operator Meaning(string src)
            => new Meaning(src);

        [MethodImpl(Inline)]
        public Meaning(object src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}", Content);
    }
}