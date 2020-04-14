//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
     
    [ApiServiceProvider]
    public partial class BV : IApiService<BV>
    {
        [MethodImpl(Inline)]
        public static Add<T> add<T>(T t = default)
            where T : unmanaged        
                => Add<T>.Op;

        [MethodImpl(Inline)]
        public static Sub<T> sub<T>(T t = default)
            where T : unmanaged        
                => Sub<T>.Op;

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
        public static Not<T> not<T>(T t = default)
            where T : unmanaged        
                => Not<T>.Op;

        [MethodImpl(Inline)]
        public static Dot<T> dot<T>(T t = default)
            where T : unmanaged        
                => Dot<T>.Op;

        [MethodImpl(Inline)]
        public static Width<T> width<T>(T t = default)
            where T : unmanaged        
                => Width<T>.Op;

        [MethodImpl(Inline)]
        public static Gather<T> gather<T>(T t = default)
            where T : unmanaged        
                => Gather<T>.Op; 
    }
}