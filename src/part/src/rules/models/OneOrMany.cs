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
            public Index<dynamic> Elements {get;}

            [MethodImpl(Inline)]
            public OneOrMany(Index<dynamic> src)
                => Elements = src;

            public static Marker<string> Indicator => "(1..*)";
        }

        /// <summary>
        /// Specifies that an element occurs at least once
        /// (1..*)
        /// </summary>
        public readonly struct OneOrMany<T> : IRule<OneOrMany<T>,T>
        {
            public Index<T> Elements {get;}

            [MethodImpl(Inline)]
            public OneOrMany(Index<T> src)
                => Elements = src;

            [MethodImpl(Inline)]
            public static implicit operator OneOrMany<T>(T[] src)
                => new OneOrMany<T>(src);

            [MethodImpl(Inline)]
            public static implicit operator OneOrMany(OneOrMany<T> src)
                => new OneOrMany(src.Elements.Dynamify());

            public static Marker<string> Indicator => OneOrMany.Indicator;
        }
    }
}