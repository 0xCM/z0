//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        /// <summary>
        /// Defines a sequence of dynamically-typed pairs with arbitrary homogeneity
        /// </summary>
        public readonly struct PairSeq
        {
            public readonly Index<Paired<dynamic,dynamic>> Terms {get;}

            [MethodImpl(Inline)]
            public PairSeq(Index<Paired<dynamic,dynamic>> src)
            {
                Terms = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator PairSeq(Paired<dynamic,dynamic>[] src)
                => new PairSeq(src);
        }

        /// <summary>
        /// Defines a sequence of homogenous T-pairs
        /// </summary>
        public readonly struct PairSeq<T>
        {
            public Index<Pair<T>> Terms {get;}

            [MethodImpl(Inline)]
            public PairSeq(Index<Pair<T>> src)
            {
                Terms = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator PairSeq<T>(Pair<T>[] src)
                => new PairSeq<T>(src);
        }

        /// <summary>
        /// Defines a sequence of non-homogenous L:R pairs
        /// </summary>
        public readonly struct PairSeq<L,R>
        {
            public Index<Paired<L,R>> Terms {get;}

            [MethodImpl(Inline)]
            public PairSeq(Index<Paired<L,R>> src)
            {
                Terms = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator PairSeq<L,R>(Paired<L,R>[] src)
                => new PairSeq<L,R>(src);
        }
    }
}