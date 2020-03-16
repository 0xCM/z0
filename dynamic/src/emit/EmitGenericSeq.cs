//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Dynop
    {
        /// <summary>
        /// Loads executable code into an index-identified buffer and covers it with a parametric unary operator
        /// </summary>
        /// <param name="buffers">The buffer index</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static UnaryOp<T> EmitUnaryOp<T>(this in BufferSeq buffers, int index, in ApiCode src)
            where T : unmanaged
                => buffers[index].Load(src.BinaryCode).EmitUnaryOp<T>(src.Id);

        /// <summary>
        /// Loads executable code into an index-identified buffer and covers it with a parametric binary operator
        /// </summary>
        /// <param name="buffers">The buffer index</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static BinaryOp<T> EmitBinaryOp<T>(this in BufferSeq buffers, int index, in ApiCode src)
            where T : unmanaged
                => buffers[index].Load(src.BinaryCode).EmitBinaryOp<T>(src.Id);

        /// <summary>
        /// Loads executable code into an index-identified buffer and covers it with a parametric ternary operator
        /// </summary>
        /// <param name="buffers">The buffer index</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static TernaryOp<T> EmitTernaryOp<T>(this in BufferSeq buffers, int index, in ApiCode src)
            where T : unmanaged
                => buffers[index].Load(src.BinaryCode).EmitTernaryOp<T>(src.Id);

        /// <summary>
        /// Loads executable code into an index-identified buffer and covers it with a fixed-parametric unary operator
        /// </summary>
        /// <param name="buffers">The buffer index</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static FixedUnaryOp<F> EmitFixedUnaryOp<F>(this in BufferSeq<F> buffers, int index, ApiCode src)
            where F : unmanaged, IFixed
                => buffers[index].EmitFixedUnaryOp<F>(src);

        /// <summary>
        /// Loads executable code into an index-identified  buffer and covers it with a fixed-parametric binary operator
        /// </summary>
        /// <param name="buffers">The buffer index</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static FixedBinaryOp<F> EmitFixedBinaryOp<F>(this in BufferSeq<F> buffers, int index, ApiCode src)
            where F : unmanaged, IFixed
                => buffers[index].EmitFixedBinaryOp<F>(src);

        /// <summary>
        /// Loads executable code into an index-identified  buffer and covers it with a fixed-parametric ternary operator
        /// </summary>
        /// <param name="buffers">The buffer index</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="F">The fixed type</typeparam>
        public static FixedTernaryOp<F> EmitFixedTernaryOp<F>(this in BufferSeq<F> buffers, int index, in ApiCode src)
            where F : unmanaged, IFixed
                => buffers[index].EmitFixedTernaryOp<F>(src);

    }
}