//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public static class Seq
    {
        public static Seq<T> define<T>(IEnumerable<T> src)
                => new Seq<T>(src); 
        public static FiniteSeq<T> finite<T>(IEnumerable<T> src)
            => new FiniteSeq<T>(src); 

        public static FiniteSeq<T> finite<T>(params T[] src)
            => new FiniteSeq<T>(src); 

        public static Seq<T> define<T>(params T[] src)
            => new Seq<T>(src); 
    }
}