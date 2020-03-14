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
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Root;

    public static class DynamicOperators
    {
        [MethodImpl(Inline)]
        public static IDynamicEmitterOpFactory<T> DynamicOperatorFactory<T>(this IContext context, N0 n, T t = default)        
            => new DynamicEmitterOpFactory<T>(context);

        [MethodImpl(Inline)]
        public static IDynamicUnaryOpFactory<T> DynamicOperatorFactory<T>(this IContext context, N1 n, T t = default)        
            => new DynamicUnaryOpFactory<T>(context);

        [MethodImpl(Inline)]
        public static IDynamicBinaryOpFactory<T> DynamicOperatorFactory<T>(this IContext context, N2 n, T t = default)        
            => new DynamicBinaryOpFactory<T>(context);

        [MethodImpl(Inline)]
        public static IDynamicTernaryOpFactory<T> DynamicOperatorFactory<T>(this IContext context, N3 n, T t = default)        
            => new DynamicTernaryOpFactory<T>(context);

        /// <summary>
        /// Creates a 128-bit vectorized parametric unary operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<UnaryOp<Vector128<T>>> EmbedV128UnaryImm<T>(this MethodInfo src, byte imm)
            where T : unmanaged
                => Dynop.CreateImmV128UnaryOp<T>(src,imm);

        /// <summary>
        /// Creates a parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<UnaryOp<Vector256<T>>> EmbedV256UnaryImm<T>(this MethodInfo src, byte imm)        
            where T : unmanaged
                => Dynop.CreateImmV256UnaryOp<T>(src,imm);

        /// <summary>
        /// Creates a parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<BinaryOp<Vector128<T>>> EmbedV128BinaryImm<T>(this MethodInfo src, byte imm)
            where T : unmanaged
                => Dynop.CreateImmV128BinaryOp<T>(src,imm);

        /// <summary>
        /// Creates a parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<BinaryOp<Vector256<T>>> EmbedV256BinaryImm<T>(this MethodInfo src, byte imm)        
            where T : unmanaged                   
                => Dynop.CreateImmV256BinaryOp<T>(src,imm);
    }
}