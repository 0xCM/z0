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
        public static EmitterOpClass emitter()
            => default;

        [KindFactory]
        public static UnaryOpClass unaryop()
            => default;

        [KindFactory]
        public static BinaryOpClass binaryop()
            => default;

        [KindFactory]
        public static TernaryOpClass ternaryop()
            => default;

        [KindFactory]
        public static ShiftOpClass shift()
            => default;

        [KindFactory, Closures(Closure)]
        public static EmitterOpClass<T> emitter<T>(T t = default)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static UnaryOpClass<T> unaryop<T>(T t = default)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static BinaryOpClass<T> binaryop<T>(T t = default)
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static TernaryOpClass<T> ternaryop<T>(T t = default)
            where T : unmanaged => default;

        public static UnaryOpClass UnaryOp
            => unaryop();

        public static BinaryOpClass BinaryOp
            => binaryop();

        public static TernaryOpClass TernaryOp
            => ternaryop();

        public static ShiftOpClass ShiftOp
            => shift();
    }
}