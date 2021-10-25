//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ops
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct scalars
    {
        [MethodImpl(Inline)]
        public static Eq<T> eq<T>(T a, T b)
            where T : IVar
                => new Eq<T>(a,b);

        [MethodImpl(Inline)]
        public static Neq<T> neq<T>(T a, T b)
            where T : IVar
                => new Neq<T>(a,b);

        [MethodImpl(Inline)]
        public static Ge<T> ge<T>(T a, T b)
            where T : IVar
                => new Ge<T>(a,b);

        [MethodImpl(Inline)]
        public static Gt<T> gt<T>(T a, T b)
            where T : IVar
                => new Gt<T>(a,b);

        [MethodImpl(Inline)]
        public static Le<T> le<T>(T a, T b)
            where T : IVar
                => new Le<T>(a,b);

        [MethodImpl(Inline)]
        public static Lt<T> lt<T>(T a, T b)
            where T : IVar
                => new Lt<T>(a,b);

        [MethodImpl(Inline)]
        public static Ngt ngt<T>(T a, T b)
            where T : IVar
                => new Ngt(a,b);

        [MethodImpl(Inline)]
        public static Nlt nlt<T>(T a, T b)
            where T : IVar
                => new Nlt(a,b);
    }
}