//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static MSvcHosts;

    partial class MSvc
    {
        [MethodImpl(Inline)]
        public static Add<T> add<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Sub<T> sub<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Mul<T> mul<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Div<T> div<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static ModOp<T> mod<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static ModMul<T> modmul<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Even<T> even<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Odd<T> odd<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Clamp<T> clamp<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Square<T> square<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Negate<T> negate<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Dec<T> dec<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Inc<T> inc<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Abs<T> abs<T>(T t = default)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Dist<T> dist<T>(T t = default)
            where T : unmanaged
                => default;
    }
}