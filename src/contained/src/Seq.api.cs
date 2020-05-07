//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    public class Seq
    {
        [MethodImpl(Inline)]
        public static Seq<T> define<T>(IEnumerable<T> src)
            => new Seq<T>(src); 

        [MethodImpl(Inline)]
        public static Seq<T> define<T>(params T[] src)
            => new Seq<T>(src); 

        [MethodImpl(Inline)]
        public static IndexedSeq<T> indexed<T>(IEnumerable<T> src)
            => new IndexedSeq<T>(src); 

        [MethodImpl(Inline)]
        public static IndexedSeq<T> indexed<T>(params T[] src)
            => new IndexedSeq<T>(src); 

    }
}