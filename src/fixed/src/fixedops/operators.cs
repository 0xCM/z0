//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial class FixedOps
    {
        /// <summary>
        /// Manufactures a fixed-parametric unary operator from T-parametric unary operator
        /// </summary>
        /// <param name="f">The source operator</param>
        /// <typeparam name="F">The target operand type</typeparam>
        /// <typeparam name="T">The source operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOp<F> fix<F,T>(UnaryOp<T> f)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => a => Fixed.fix<T,F>(f(Fixed.unfix<F,T>(a)));

        /// <summary>
        /// Manufactures a fixed-parametric binary operator from T-parametric binary operator
        /// </summary>
        /// <param name="f">The source operator</param>
        /// <typeparam name="F">The target operand type</typeparam>
        /// <typeparam name="T">The source operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<F> fix<F,T>(BinaryOp<T> f)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => (F a, F b) => Fixed.fix<T,F>(f(Fixed.unfix<F,T>(a), Fixed.unfix<F,T>(b)));

        /// <summary>
        /// Manufactures a T-parametric unary operator from a fixed-parametric unary operator
        /// </summary>
        /// <param name="f">The source operator</param>
        /// <typeparam name="F">The source operand type</typeparam>
        /// <typeparam name="T">The target operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOp<T> unfix<F,T>(UnaryOp<F> f)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => a => Fixed.unfix<F,T>(f(Fixed.fix<T,F>(a)));

        /// <summary>
        /// Manufactures a T-parametric binary operator from a fixed-parametric binary operator
        /// </summary>
        /// <param name="f">The source operator</param>
        /// <typeparam name="F">The source operand type</typeparam>
        /// <typeparam name="T">The target operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<T> unfix<F,T>(BinaryOp<F> f)
            where F : unmanaged, IDataCell
            where T : unmanaged
                => (T a, T b) => Fixed.unfix<F,T>(f(Fixed.fix<T,F>(a), Fixed.fix<T,F>(b)));
    }
}