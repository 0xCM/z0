//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Kinds
    {
        [KindFactory]
        public static UnaryActionClass action(A1 rep)
            => default;

        [KindFactory]
        public static BinaryActionClass action(A2 rep)
            => default;

        [KindFactory]
        public static TernaryActionClass action(A3 rep)
            => default;

        [KindFactory, Closures(Closure)]
        public static ReceiverClass<T> receiver<T>()
            where T : unmanaged => default;

        [KindFactory, Closures(Closure)]
        public static UnaryActionClass<T> action<T>(A1<T> rep)
            where T : unmanaged =>  default;

        [KindFactory, Closures(Closure)]
        public static BinaryActionClass<T> action<T>(A2<T> rep)
            where T : unmanaged =>  default;

        [KindFactory, Closures(Closure)]
        public static TernaryActionClass<T> action<T>(A3<T> rep)
            where T : unmanaged =>  default;
    }
}