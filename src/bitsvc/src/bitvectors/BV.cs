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
        public static Add<T> add<T>(T t = default)
            where T : unmanaged
                => sfunc<Add<T>>();

        [MethodImpl(Inline)]
        public static Sub<T> sub<T>(T t = default)
            where T : unmanaged
                => sfunc<Sub<T>>();

        [MethodImpl(Inline)]
        public static And<T> and<T>(T t = default)
            where T : unmanaged
                => sfunc<And<T>>();

        [MethodImpl(Inline)]
        public static Or<T> or<T>(T t = default)
            where T : unmanaged
                => sfunc<Or<T>>();

        [MethodImpl(Inline)]
        public static Xor<T> xor<T>(T t = default)
            where T : unmanaged
                => sfunc<Xor<T>>();

        [MethodImpl(Inline)]
        public static Nand<T> nand<T>(T t = default)
            where T : unmanaged
                => sfunc<Nand<T>>();

        [MethodImpl(Inline)]
        public static Nor<T> nor<T>(T t = default)
            where T : unmanaged
                => sfunc<Nor<T>>();

        [MethodImpl(Inline)]
        public static Xnor<T> xnor<T>(T t = default)
            where T : unmanaged
                => sfunc<Xnor<T>>();

        [MethodImpl(Inline)]
        public static Not<T> not<T>(T t = default)
            where T : unmanaged
                => sfunc<Not<T>>();

        [MethodImpl(Inline)]
        public static Dot<T> dot<T>(T t = default)
            where T : unmanaged
                => sfunc<Dot<T>>();

        [MethodImpl(Inline)]
        public static Width<T> width<T>(T t = default)
            where T : unmanaged
                => sfunc<Width<T>>();

        [MethodImpl(Inline)]
        public static Gather<T> gather<T>(T t = default)
            where T : unmanaged
                => sfunc<Gather<T>>();
    }
}