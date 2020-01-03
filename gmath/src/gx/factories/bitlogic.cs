//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;
    using static GXTypes;

    partial class GX
    {
       [MethodImpl(Inline)]
       public static And<T> and<T>(T t = default)
            where T : unmanaged        
                => And<T>.Op;
 
        [MethodImpl(Inline)]
        public static Or<T> or<T>(T t = default)
            where T : unmanaged        
                => Or<T>.Op;

        [MethodImpl(Inline)]
        public static Xor<T> xor<T>(T t = default)
            where T : unmanaged        
                => Xor<T>.Op;

        [MethodImpl(Inline)]
        public static Nand<T> nand<T>(T t = default)
            where T : unmanaged        
                => Nand<T>.Op;

        [MethodImpl(Inline)]
        public static Nor<T> nor<T>(T t = default)
            where T : unmanaged        
                => Nor<T>.Op;

        [MethodImpl(Inline)]
        public static Xnor<T> xnor<T>(T t = default)
            where T : unmanaged        
                => Xnor<T>.Op;

        [MethodImpl(Inline)]
        public static Select<T> select<T>(T t = default)
            where T : unmanaged        
                => Select<T>.Op;

        [MethodImpl(Inline)]
        public static Not<T> not<T>(T t = default)
            where T : unmanaged        
                => Not<T>.Op;
    }
}