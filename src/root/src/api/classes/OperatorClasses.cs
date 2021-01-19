//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    public readonly struct OperatorClasses
    {
        const NumericKind Closure = NumericKind.All;

        [KindFactory]
        public static EmitterClass emitter()
            => default;

        [KindFactory]
        public static UnaryClass unary()
            => default;

        [KindFactory]
        public static BinaryClass binary()
            => default;

        [KindFactory]
        public static TernaryClass ternary()
            => default;

        [KindFactory]
        public static ShiftClass shift()
            => default;

        [KindFactory, Closures(Closure)]
        public static EmitterClass<T> emitter<T>(T t = default)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static UnaryClass<T> unary<T>(T t = default)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static BinaryClass<T> binary<T>(T t = default)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static TernaryClass<T> ternary<T>(T t = default)
            where T : unmanaged => default;
    }
}