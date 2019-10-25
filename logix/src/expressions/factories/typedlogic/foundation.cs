//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;


    public static partial class TypedLogicSpec
    {
        /// <summary>
        /// Creates a literal expression
        /// </summary>
        /// <param name="value">The literal value</param>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static TypedLiteralExpr<T> literal<T>(T value)
            where T : unmanaged
                => new TypedLiteralExpr<T>(value);

        /// <summary>
        /// Creates a bitwise unary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitwiseOpSpec<T> unary<T>(UnaryBitwiseOpKind op, ITypedExpr<T> operand)
            where T : unmanaged
                => new UnaryBitwiseOpSpec<T>(op,operand);

        /// <summary>
        /// Creates a bitwise binary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> binary<T>(BinaryBitwiseOpKind op, ITypedExpr<T> left, ITypedExpr<T> right)
            where T : unmanaged
                => new BinaryBitwiseOp<T>(op,left,right);

        /// <summary>
        /// Creates a bitwise ternary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static TernaryBitwiseOp<T> ternary<T>(TernaryBitOpKind op, ITypedExpr<T> a, ITypedExpr<T> b, ITypedExpr<T> c)
            where T : unmanaged
                => new TernaryBitwiseOp<T>(op,a,b,c);

        /// <summary>
        /// Defines a scalar range expression
        /// </summary>
        /// <param name="min">The minimum scalar in the range</param>
        /// <param name="max">The maximum scalar in the range</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static RangeExpr<T> rangexpr<T>(T min, T max, T? step = null)
            where T : unmanaged
                => new RangeExpr<T>(min,max,step);

        

    }       
}