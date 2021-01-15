//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static SFx;

    [FunctionalService]
    public partial class BV : ISFxHost<BV>
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        public static Add<T> add<T>()
            where T : unmanaged
                => sfunc<Add<T>>();

        [MethodImpl(Inline)]
        public static Sub<T> sub<T>()
            where T : unmanaged
                => sfunc<Sub<T>>();

        [MethodImpl(Inline)]
        public static And<T> and<T>()
            where T : unmanaged
                => sfunc<And<T>>();

        [MethodImpl(Inline)]
        public static Or<T> or<T>()
            where T : unmanaged
                => sfunc<Or<T>>();

        [MethodImpl(Inline)]
        public static Xor<T> xor<T>()
            where T : unmanaged
                => sfunc<Xor<T>>();

        [MethodImpl(Inline)]
        public static Nand<T> nand<T>()
            where T : unmanaged
                => sfunc<Nand<T>>();

        [MethodImpl(Inline)]
        public static Nor<T> nor<T>(T t = default)
            where T : unmanaged
                => sfunc<Nor<T>>();

        [MethodImpl(Inline)]
        public static Xnor<T> xnor<T>()
            where T : unmanaged
                => sfunc<Xnor<T>>();

        [MethodImpl(Inline)]
        public static Not<T> not<T>()
            where T : unmanaged
                => sfunc<Not<T>>();

        [MethodImpl(Inline)]
        public static Dot<T> dot<T>()
            where T : unmanaged
                => sfunc<Dot<T>>();

        [MethodImpl(Inline)]
        public static EffWidth<T> effwidth<T>()
            where T : unmanaged
                => sfunc<EffWidth<T>>();

        [MethodImpl(Inline)]
        public static Gather<T> gather<T>(T t = default)
            where T : unmanaged
                => sfunc<Gather<T>>();
    }
}