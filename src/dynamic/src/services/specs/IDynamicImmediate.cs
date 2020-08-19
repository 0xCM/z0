//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Konst;

    public interface IDynamicImmediate
    {
        /// <summary>
        /// Creates a unary operator with an embedded immediate value
        /// </summary>
        /// <param name="w">The operand width</param>
        /// <param name="src">The defining method that requires an immediate value</param>
        /// <param name="imm">The immediate value to embed</param>
        Option<DynamicDelegate> CreateUnaryOp(TypeWidth w, MethodInfo src, byte imm);

        /// <summary>
        /// Creates a binary operator with an embedded immediate value
        /// </summary>
        /// <param name="w">The operand width</param>
        /// <param name="src">The defining method that requires an immediate value</param>
        /// <param name="imm">The immediate value to embed</param>
        Option<DynamicDelegate> CreateBinaryOp(TypeWidth w, MethodInfo src, byte imm);

        /// <summary>
        /// Creates an immediate injector for unary operators with non-immediate operands of parametric width
        /// </summary>
        /// <typeparam name="W">The operand width</typeparam>
        IImmInjector UnaryInjector<W>()
            where W : ITypeWidth;

        /// <summary>
        /// Creates an immediate injector for binary operators with non-immediate operands of parametric width
        /// </summary>
        /// <typeparam name="W">The operand width</typeparam>
        IImmInjector BinaryInjector<W>()
            where W : ITypeWidth;

        /// <summary>
        /// Creates a 128-bit T-parametric unary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        IImmInjector<UnaryOp<Vector128<T>>> UnaryInjector<T>(W128 w)
            where T : unmanaged;

        /// <summary>
        /// Creates a 256-bit T-parametric unary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        IImmInjector<UnaryOp<Vector256<T>>> UnaryInjector<T>(W256 w)
            where T : unmanaged;

        /// <summary>
        /// Creates a 128-bit T-parametric binary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        IImmInjector<BinaryOp<Vector128<T>>> BinaryInjector<T>(W128 w)
            where T : unmanaged;

        /// <summary>
        /// Creates a 256-bit T-parametric binary immediate injector
        /// </summary>
        /// <param name="w">The vector operand width</param>
        /// <param name="k">The operator kind</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        IImmInjector<BinaryOp<Vector256<T>>> BinaryInjector<T>(W256 w)
            where T : unmanaged;

        /// <summary>
        /// Creates a 128-bit vectorized parametric unary operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        DynamicDelegate<UnaryOp<Vector128<T>>> CreateUnaryOp<T>(MethodInfo src, W128 w, byte imm)
            where T : unmanaged;

        /// <summary>
        /// Creates a parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        DynamicDelegate<BinaryOp<Vector128<T>>> CreateBinaryOp<T>(MethodInfo src, W128 w, byte imm)
            where T : unmanaged;

        /// <summary>
        /// Creates a parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        DynamicDelegate<UnaryOp<Vector256<T>>> CreateUnaryOp<T>(MethodInfo src, W256 w, byte imm)
            where T : unmanaged;

        /// <summary>
        /// Creates a parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        DynamicDelegate<BinaryOp<Vector256<T>>> CreateBinaryOp<T>(MethodInfo src, W256 w, byte imm)
            where T : unmanaged;
    }
}