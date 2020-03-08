//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static BVTypes;

    public static partial class BV
    {
        [MethodImpl(Inline)]
        public static And<T> bvand<T>(T t = default)
            where T : unmanaged        
                => And<T>.Op;

        [MethodImpl(Inline)]
        public static Or<T> bvor<T>(T t = default)
            where T : unmanaged        
                => Or<T>.Op;

        [MethodImpl(Inline)]
        public static Xor<T> bvxor<T>(T t = default)
            where T : unmanaged        
                => Xor<T>.Op;

        [MethodImpl(Inline)]
        public static Nand<T> bvnand<T>(T t = default)
            where T : unmanaged        
                => Nand<T>.Op;

        [MethodImpl(Inline)]
        public static Nor<T> bvnor<T>(T t = default)
            where T : unmanaged        
                => Nor<T>.Op;

        [MethodImpl(Inline)]
        public static Xnor<T> bvxnor<T>(T t = default)
            where T : unmanaged        
                => Xnor<T>.Op;

        [MethodImpl(Inline)]
        public static Not<T> bvnot<T>(T t = default)
            where T : unmanaged        
                => Not<T>.Op;

        [MethodImpl(Inline)]
        public static Dot<T> bvdot<T>(T t = default)
            where T : unmanaged        
                => Dot<T>.Op;

        [MethodImpl(Inline)]
        public static Width<T> bvwidth<T>(T t = default)
            where T : unmanaged        
                => Width<T>.Op;

        [MethodImpl(Inline)]
        public static Gather<T> bvgather<T>(T t = default)
            where T : unmanaged        
                => Gather<T>.Op;
    }
}