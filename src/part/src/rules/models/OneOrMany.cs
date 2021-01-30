//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Rules
    {
        /// <summary>
        /// Specifies that an element occurs at least once
        /// </summary>
        public readonly struct OneOrMany : IRule<OneOrMany>
        {
            public dynamic Element {get;}

            [MethodImpl(Inline)]
            public OneOrMany(dynamic src)
                => Element = src;

            public static Marker<string> Indicator => "(1..*)";
        }

        /// <summary>
        /// Specifies that an element occurs at least once
        /// (1..*)
        /// </summary>
        public readonly struct OneOrMany<T> : IRule<OneOrMany<T>,T>
        {
            public T Element {get;}

            [MethodImpl(Inline)]
            public OneOrMany(T src)
                => Element = src;

            [MethodImpl(Inline)]
            public static implicit operator OneOrMany<T>(T src)
                => new OneOrMany<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator OneOrMany(OneOrMany<T> src)
                => new OneOrMany(src);

            public static Marker<string> Indicator => OneOrMany.Indicator;
        }
    }
}