//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Kinds
    {
        [KindFactory]
        public static OperatorClass @operator()
            => default;

        [KindFactory]
        public static EmitterClass emitter()
            => default;

        [KindFactory]
        public static UnaryClass unaryop()
            => default;

        [KindFactory]
        public static BinaryClass binaryop()
            => default;

        [KindFactory]
        public static TernaryClass ternaryop()
            => default;

        [KindFactory]
        public static ShiftClass shift()
            => default;

        [KindFactory, Closures(Closure)]
        public static EmitterClass<T> emitter<T>(T t = default)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static UnaryClass<T> unaryop<T>(T t = default)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static BinaryClass<T> binaryop<T>(T t = default)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static TernaryClass<T> ternaryop<T>(T t = default)
            where T : unmanaged => default;

        public static UnaryClass UnaryOp
            => unaryop();

        public static BinaryClass BinaryOp
            => binaryop();

        public static TernaryClass TernaryOp
            => ternaryop();

        public static ShiftClass ShiftOp
            => shift();
    }
}