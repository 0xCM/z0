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

    using static Imm8OpProviders;

    partial class Dynop
    {
        [MethodImpl(Inline)]
        public static IImm8OpProvider ImmProvider(VKT.Vec128 hk, UnaryOpType opk)
            => default(Imm8V128Unary);

        [MethodImpl(Inline)]
        public static IImm8OpProvider ImmProvider(VKT.Vec256 hk, UnaryOpType opk)
            => default(Imm8V256Unary);

        [MethodImpl(Inline)]
        public static IImm8OpProvider ImmProvider(VKT.Vec128 hk, BinaryOpType opk)
            => default(Imm8V128Binary);

        [MethodImpl(Inline)]
        public static IImm8OpProvider ImmProvider(VKT.Vec256 hk, BinaryOpType opk)
            => default(Imm8V256Binary);

        [MethodImpl(Inline)]
        public static IImm8OpProvider<UnaryOp<Vector128<T>>> ImmProvider<T>(VKT.Vec128<T> vk, UnaryOpType opk)
            where T : unmanaged
                => default(Imm8V128Unary<T>);

        [MethodImpl(Inline)]
        public static IImm8OpProvider<UnaryOp<Vector256<T>>> ImmProvider<T>(VKT.Vec256<T> vk, UnaryOpType opk)
            where T : unmanaged
                => default(Imm8VUnary<T>);

        [MethodImpl(Inline)]
        public static IImm8OpProvider<BinaryOp<Vector128<T>>> ImmProvider<T>(VKT.Vec128<T> vk, BinaryOpType opk)
            where T : unmanaged
                => default(Imm8V128Binary<T>);

        [MethodImpl(Inline)]
        public static IImm8OpProvider<BinaryOp<Vector256<T>>> ImmProvider<T>(VKT.Vec256<T> vk, BinaryOpType opk)
            where T : unmanaged
                => default(Imm8V256Binary<T>); 
    }


    static class Imm8OpProviders
    {        
        public readonly struct Imm8V128Binary : IImm8OpProvider
        {
            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => Dynop.ImmV128BinaryDelegate(src,imm);
        }

        public readonly struct Imm8V128Binary<T> : IImm8OpProvider<BinaryOp<Vector128<T>>>
            where T : unmanaged
        {

            [MethodImpl(Inline)]            
            public DynamicDelegate<BinaryOp<Vector128<T>>> CreateOp(MethodInfo src, byte imm)
                => Dynop.ImmV128BinaryOp<T>(src,imm);
        }

        public readonly struct Imm8V256Binary : IImm8OpProvider
        {
            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => Dynop.ImmV256BinaryDelegate(src,imm);
        }

        public readonly struct Imm8V256Binary<T> : IImm8OpProvider<BinaryOp<Vector256<T>>>
            where T : unmanaged
        { 
            [MethodImpl(Inline)]            
            public DynamicDelegate<BinaryOp<Vector256<T>>> CreateOp(MethodInfo src, byte imm)
                => Dynop.ImmV256BinaryOp<T>(src,imm);
        }

        public readonly struct Imm8V256Unary : IImm8OpProvider
        {        
            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => Dynop.ImmV256UnaryDelegate(src,imm);
        }

        public readonly struct Imm8VUnary<T> : IImm8OpProvider<UnaryOp<Vector256<T>>>
            where T : unmanaged
        {            
            [MethodImpl(Inline)]            
            public DynamicDelegate<UnaryOp<Vector256<T>>> CreateOp(MethodInfo src, byte imm)
                => Dynop.ImmV256UnaryOp<T>(src,imm);
        }

        public readonly struct Imm8V128Unary : IImm8OpProvider
        {
            [MethodImpl(Inline)]            
            public DynamicDelegate CreateOp(MethodInfo src, byte imm)
                => Dynop.ImmV128UnaryDelegate(src,imm);
        }

        public readonly struct Imm8V128Unary<T> : IImm8OpProvider<UnaryOp<Vector128<T>>>
            where T : unmanaged
        {
            [MethodImpl(Inline)]            
            public DynamicDelegate<UnaryOp<Vector128<T>>> CreateOp(MethodInfo src, byte imm)
                => Dynop.ImmV128UnaryOp<T>(src,imm);
        }
    }
}