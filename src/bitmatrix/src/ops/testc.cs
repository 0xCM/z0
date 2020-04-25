//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed; 
    using static Memories;    

    partial class BitMatrix
    {
        /// <summary>
        /// Returns true if all bits in a source matrix are enabled, false otherwise
        /// </summary>
        /// <param name="a">The source matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit testc<T>(in BitMatrix<T> a)
            where T : unmanaged
                => LogicSquare.testc(a.Head);
                
        /// <summary>
        /// Returns true if all bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="a">The source matrix</param>
        /// <param name="B">The mask matrix</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline), TestC, Closures(UnsignedInts)]
        public static bit testc<T>(in BitMatrix<T> a, in BitMatrix<T> mask)
            where T : unmanaged
                => LogicSquare.testc(a.Head, mask.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="a">The source matrix</param>
        [MethodImpl(Inline), TestC]
        public static bit testc(in BitMatrix8 a)
            => LogicSquare.testc(a.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="a">The source matrix</param>
        /// <param name="mask">The mask matrix</param>
        [MethodImpl(Inline), TestC]
        public static bit testc(in BitMatrix8 a, in BitMatrix8 mask)
            => LogicSquare.testc(a.Head, mask.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="a">The source matrix</param>
        [MethodImpl(Inline), TestC]
        public static bit testc(in BitMatrix16 a)
            => LogicSquare.testc(a.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="a">The source matrix</param>
        /// <param name="mask">The mask matrix</param>
        [MethodImpl(Inline), TestC]
        public static bit testc(in BitMatrix16 a, in BitMatrix16 mask)
            => LogicSquare.testc(a.Head, mask.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="a">The source matrix</param>
        [MethodImpl(Inline), TestC]
        public static bit testc(in BitMatrix32 a)
            => LogicSquare.testc(a.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="a">The source matrix</param>
        /// <param name="mask">The mask matrix</param>
        [MethodImpl(Inline), TestC]
        public static bit testc(in BitMatrix32 a, in BitMatrix32 mask)
            => LogicSquare.testc(a.Head, mask.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="a">The source matrix</param>
        [MethodImpl(Inline), TestC]
        public static bit testc(in BitMatrix64 a)
            => LogicSquare.testc(a.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="a">The source matrix</param>
        /// <param name="mask">The mask matrix</param>
        [MethodImpl(Inline), TestC]
        public static bit testc(in BitMatrix64 a, in BitMatrix64 mask)
            => LogicSquare.testc(a.Head, mask.Head);
    }
}