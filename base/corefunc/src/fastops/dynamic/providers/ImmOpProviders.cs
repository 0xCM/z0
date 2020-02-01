//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static partial class ImmOpProviders
    {        
        [MethodImpl(Inline)]
        public static IImmOpProvider provider(HK.Vec128 hk, HK.UnaryOp opk)
            =>default(ImmUnaryV128);

        [MethodImpl(Inline)]
        public static IImmOpProvider provider(HK.Vec256 hk, HK.UnaryOp opk)
            => default(ImmUnaryV256);

        [MethodImpl(Inline)]
        public static IImmOpProvider provider(HK.Vec128 hk, HK.BinaryOp opk)
            => default(ImmBinaryV128);

        [MethodImpl(Inline)]
        public static IImmOpProvider provider(HK.Vec256 hk, HK.BinaryOp opk)
            => default(ImmBinaryV256);

        [MethodImpl(Inline)]
        public static IImmOpProvider<UnaryOp<Vector128<T>>> provider<T>(HK.Vec128<T> vk, HK.UnaryOp opk)
            where T : unmanaged
                => default(ImmUnaryV128<T>);

        [MethodImpl(Inline)]
        public static IImmOpProvider<UnaryOp<Vector256<T>>> provider<T>(HK.Vec256<T> vk, HK.UnaryOp opk)
            where T : unmanaged
                => default(ImmUnaryV256<T>);

        [MethodImpl(Inline)]
        public static IImmOpProvider<BinaryOp<Vector128<T>>> provider<T>(HK.Vec128<T> vk, HK.BinaryOp opk)
            where T : unmanaged
                => default(ImmBinaryV128<T>);

        [MethodImpl(Inline)]
        public static IImmOpProvider<BinaryOp<Vector256<T>>> provider<T>(HK.Vec256<T> vk, HK.BinaryOp opk)
            where T : unmanaged
                => default(ImmBinaryV256<T>);

    }
}