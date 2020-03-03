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

    using static Root;
    using static FKT;

    public static class ImmOpProviders
    {        
        [MethodImpl(Inline)]
        public static IImmOpProvider provider(VKT.Vec128 hk, UnaryOpType opk)
            => default(ImmUnaryV128);

        [MethodImpl(Inline)]
        public static IImmOpProvider provider(VKT.Vec256 hk, UnaryOpType opk)
            => default(ImmUnaryV256);

        [MethodImpl(Inline)]
        public static IImmOpProvider provider(VKT.Vec128 hk, BinaryOpType opk)
            => default(ImmBinaryV128);

        [MethodImpl(Inline)]
        public static IImmOpProvider provider(VKT.Vec256 hk, BinaryOpType opk)
            => default(ImmBinaryV256);

        [MethodImpl(Inline)]
        public static IImmOpProvider<UnaryOp<Vector128<T>>> provider<T>(VKT.Vec128<T> vk, UnaryOpType opk)
            where T : unmanaged
                => default(ImmUnaryV128<T>);

        [MethodImpl(Inline)]
        public static IImmOpProvider<UnaryOp<Vector256<T>>> provider<T>(VKT.Vec256<T> vk, UnaryOpType opk)
            where T : unmanaged
                => default(ImmUnaryV256<T>);

        [MethodImpl(Inline)]
        public static IImmOpProvider<BinaryOp<Vector128<T>>> provider<T>(VKT.Vec128<T> vk, BinaryOpType opk)
            where T : unmanaged
                => default(ImmBinaryV128<T>);

        [MethodImpl(Inline)]
        public static IImmOpProvider<BinaryOp<Vector256<T>>> provider<T>(VKT.Vec256<T> vk, BinaryOpType opk)
            where T : unmanaged
                => default(ImmBinaryV256<T>);

        readonly struct ImmBinaryV128 : IImmOpProvider
        {
            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => Dynop.BinaryV128Imm(src,imm);
        }

        readonly struct ImmBinaryV128<T> : IImmOpProvider<BinaryOp<Vector128<T>>>
            where T : unmanaged
        {

            [MethodImpl(Inline)]            
            public DynamicDelegate<BinaryOp<Vector128<T>>> CreateOp(MethodInfo src, byte imm)
                => Dynop.BinaryOpV128Imm<T>(src,imm);
        }

        readonly struct ImmBinaryV256 : IImmOpProvider
        {
            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => Dynop.BinaryOpV256Imm(src,imm);
        }

        readonly struct ImmBinaryV256<T> : IImmOpProvider<BinaryOp<Vector256<T>>>
            where T : unmanaged
        { 
            [MethodImpl(Inline)]            
            public DynamicDelegate<BinaryOp<Vector256<T>>> CreateOp(MethodInfo src, byte imm)
                => Dynop.BinaryOpV256Imm<T>(src,imm);
        }

        readonly struct ImmUnaryV256 : IImmOpProvider
        {        
            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => Dynop.UnaryOpV256Imm(src,imm);
        }

        readonly struct ImmUnaryV256<T> : IImmOpProvider<UnaryOp<Vector256<T>>>
            where T : unmanaged
        {            
            [MethodImpl(Inline)]            
            public DynamicDelegate<UnaryOp<Vector256<T>>> CreateOp(MethodInfo src, byte imm)
                => Dynop.UnaryOpV256Imm<T>(src,imm);
        }

        readonly struct ImmUnaryV128 : IImmOpProvider
        {
            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => Dynop.UnaryOpV128Imm(src,imm);
        }

        readonly struct ImmUnaryV128<T> : IImmOpProvider<UnaryOp<Vector128<T>>>
            where T : unmanaged
        {
            [MethodImpl(Inline)]            
            public DynamicDelegate<UnaryOp<Vector128<T>>> CreateOp(MethodInfo src, byte imm)
                => Dynop.UnaryOpV128Imm<T>(src,imm);
        }
    }
}