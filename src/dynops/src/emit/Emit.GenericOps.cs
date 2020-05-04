//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Dynop
    {
        /// <summary>
        /// Loads executable code into a token-identified buffer and covers it with a parametric unary operator
        /// </summary>
        /// <param name="buffer">The buffer hande</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static UnaryOp<T> EmitUnaryOp<T>(this IBufferToken buffer, UriBits src)
            where T : unmanaged
                => buffer.Load(src.Encoded).EmitUnaryOp<T>(src.Id);

        /// <summary>
        /// Loads executable code into a token-identified buffer and covers it with a parametric binary operator
        /// </summary>
        /// <param name="buffer">The buffer hande</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static BinaryOp<T> EmitBinaryOp<T>(this IBufferToken buffer, UriBits src)
            where T : unmanaged
                => buffer.Load(src.Encoded).EmitBinaryOp<T>(src.Id);

        /// <summary>
        /// Loads executable code into a token-identified buffer and covers it with a parametric ternary operator
        /// </summary>
        /// <param name="dst">The buffer hande</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static TernaryOp<T> EmitTernaryOp<T>(this IBufferToken dst, UriBits src)
            where T : unmanaged
                => dst.Load(src.Encoded).EmitTernaryOp<T>(src.Id);
    }
}