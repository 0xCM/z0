//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
     
    [ApiServiceFactory]
    public partial class BV : IFunctional<BV>
    {
        [MethodImpl(Inline)]
        public static Add<T> add<T>(T t = default)
            where T : unmanaged        
                => default(Add<T>);

        [MethodImpl(Inline)]
        public static Sub<T> sub<T>(T t = default)
            where T : unmanaged        
                => default(Sub<T>);

        [MethodImpl(Inline)]
        public static And<T> and<T>(T t = default)
            where T : unmanaged        
                => default(And<T>);

        [MethodImpl(Inline)]
        public static Or<T> or<T>(T t = default)
            where T : unmanaged        
                => default(Or<T>);

        [MethodImpl(Inline)]
        public static Xor<T> xor<T>(T t = default)
            where T : unmanaged        
                => default(Xor<T>);

        [MethodImpl(Inline)]
        public static Nand<T> nand<T>(T t = default)
            where T : unmanaged        
                => default(Nand<T>);

        [MethodImpl(Inline)]
        public static Nor<T> nor<T>(T t = default)
            where T : unmanaged        
                => default(Nor<T>);

        [MethodImpl(Inline)]
        public static Xnor<T> xnor<T>(T t = default)
            where T : unmanaged        
                => default(Xnor<T>);

        [MethodImpl(Inline)]
        public static Not<T> not<T>(T t = default)
            where T : unmanaged        
                => default(Not<T>);

        [MethodImpl(Inline)]
        public static Dot<T> dot<T>(T t = default)
            where T : unmanaged        
                => default(Dot<T>);

        [MethodImpl(Inline)]
        public static Width<T> width<T>(T t = default)
            where T : unmanaged        
                => default(Width<T>);

        [MethodImpl(Inline)]
        public static Gather<T> gather<T>(T t = default)
            where T : unmanaged        
                => default(Gather<T>); 
    }
}