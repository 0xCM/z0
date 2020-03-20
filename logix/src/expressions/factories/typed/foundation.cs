//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public static partial class TypedLogicSpec
    {
        /// <summary>
        /// Creates a literal expression
        /// </summary>
        /// <param name="value">The literal value</param>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<T> literal<T>(T value)
            where T : unmanaged
                => new LiteralExpr<T>(value);

        /// <summary>
        /// Creates a bitwise unary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="operand">The operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitwiseOpExpr<T> unary<T>(UnaryBitLogicOpKind op, IExpr<T> operand)
            where T : unmanaged
                => new UnaryBitwiseOpExpr<T>(op,operand);

        /// <summary>
        /// Creates a bitwise binary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> binary<T>(BinaryBitLogicOpKind op, IExpr<T> left, IExpr<T> right)
            where T : unmanaged
                => new BinaryBitwiseOpExpr<T>(op,left,right);

        /// <summary>
        /// Creates a binary comparison expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="left">The left operand</param>
        /// <param name="right">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ComparisonExpr<T> binary<T>(ComparisonOpKind op, IExpr<T> left, IExpr<T> right)
            where T : unmanaged
                => new ComparisonExpr<T>(op,left,right);

        /// <summary>
        /// Creates a bitwise ternary expression
        /// </summary>
        /// <param name="op">The operator classifier</param>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static TernaryBitwiseOpExpr<T> ternary<T>(TernaryBitLogicOpKind op, IExpr<T> a, IExpr<T> b, IExpr<T> c)
            where T : unmanaged
                => new TernaryBitwiseOpExpr<T>(op,a,b,c);

        /// <summary>
        /// Defines a scalar range expression
        /// </summary>
        /// <param name="min">The minimum scalar in the range</param>
        /// <param name="max">The maximum scalar in the range</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static RangeExpr<T> rangexpr<T>(T min, T max, T? step = null)
            where T : unmanaged
                => new RangeExpr<T>(min,max,step ?? one<T>());        
    }       
}