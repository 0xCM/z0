//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static MSvcHosts;

    partial class MSvc
    {
        [MethodImpl(Inline)]
        public static Eq<T> eq<T>(T t = default)
            where T : unmanaged        
                => default(Eq<T>);

        [MethodImpl(Inline)]
        public static Neq<T> neq<T>(T t = default)
            where T : unmanaged        
                => default(Neq<T>);

        [MethodImpl(Inline)]
        public static Lt<T> lt<T>(T t = default)
            where T : unmanaged        
                => default(Lt<T>);

        [MethodImpl(Inline)]
        public static LtEq<T> lteq<T>(T t = default)
            where T : unmanaged        
                => default(LtEq<T>);

        [MethodImpl(Inline)]
        public static Gt<T> gt<T>(T t = default)
            where T : unmanaged        
                => default(Gt<T>);

        [MethodImpl(Inline)]
        public static GtEq<T> gteq<T>(T t = default)
            where T : unmanaged        
                => default(GtEq<T>);

        [MethodImpl(Inline)]
        public static Between<T> between<T>(T t = default)
            where T : unmanaged        
                => default(Between<T>);

        [MethodImpl(Inline)]
        public static Nonz<T> nonz<T>(T t = default)
            where T : unmanaged        
                => default(Nonz<T>);

        [MethodImpl(Inline)]
        public static PositiveOp<T> positive<T>(T t = default)
            where T : unmanaged        
                => default(PositiveOp<T>);

        [MethodImpl(Inline)]
        public static NegativeOp<T> negative<T>(T t = default)
            where T : unmanaged        
                => default(NegativeOp<T>);

        [MethodImpl(Inline)]
        public static Min<T> min<T>(T t = default)
            where T : unmanaged        
                => default(Min<T>);

        [MethodImpl(Inline)]
        public static Max<T> max<T>(T t = default)
            where T : unmanaged        
                => default(Max<T>);
    }
}