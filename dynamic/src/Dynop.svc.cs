//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Root;
    using static Nats;
    using static FKT;

    public static class DynopServices
    {
        [MethodImpl(Inline)]
        public static IImm8OpProvider ImmV128UnaryOpProvider(this IContext context)
            => new Imm8OpProvider(context, VK.vk128(), FK.op(n1));

        [MethodImpl(Inline)]
        public static IImm8OpProvider ImmV256UnaryOpProvider(this IContext context)
            => new Imm8OpProvider(context, VK.vk256(), FK.op(n1));

        [MethodImpl(Inline)]
        public static IImm8OpProvider ImmV128BinaryOpProvider(this IContext context)
            => new Imm8OpProvider(context,VK.vk128(), FK.op(n2));

        [MethodImpl(Inline)]
        public static IImm8OpProvider ImmV256BinaryOpProvider(this IContext context)
            => new Imm8OpProvider(context, VK.vk256(), FK.op(n2));


        [MethodImpl(Inline)]
        public static IImm8OpProvider<UnaryOp<Vector128<T>>> ImmV128UnaryOpProvider<T>(this IContext context)
            where T : unmanaged
                => new Imm8OpProvider<UnaryOp<Vector128<T>>>(context, new Imm8V128UnaryOpProvider<T>(context));

        [MethodImpl(Inline)]
        public static IImm8OpProvider<BinaryOp<Vector128<T>>> ImmV128BinaryOpProvider<T>(this IContext context)
            where T : unmanaged
                => new Imm8OpProvider<BinaryOp<Vector128<T>>>(context, new Imm8V128BinaryOpProvider<T>(context));

        [MethodImpl(Inline)]
        public static IImm8OpProvider<UnaryOp<Vector256<T>>> ImmV256UnaryOpProvider<T>(this IContext context)
            where T : unmanaged
                => new Imm8OpProvider<UnaryOp<Vector256<T>>>(context, new Imm8VUnaryOpProvider<T>(context));

        [MethodImpl(Inline)]
        public static IImm8OpProvider<BinaryOp<Vector256<T>>> ImmV256BinaryOpProvider<T>(this IContext context)
            where T : unmanaged
                => new Imm8OpProvider<BinaryOp<Vector256<T>>>(context, new Imm8V256BinaryOpProvider<T>(context));
    }
}