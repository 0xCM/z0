//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        /// <summary>
        /// Returns true if all bits in a source matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is constructed</typeparam>
        [MethodImpl(Inline)]
        public static bit testc<T>(in BitMatrix<T> A)
            where T : unmanaged
                => BitBlocks.testc(in A.Head);
                
        /// <summary>
        /// Returns true if all bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The mask matrix</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static bit testc<T>(in BitMatrix<T> A, in BitMatrix<T> M)
            where T : unmanaged
                => BitBlocks.testc(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testc(in BitMatrix8 A)
            => BitBlocks.testc(in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testc(in BitMatrix8 A, in BitMatrix8 M)
            => BitBlocks.testc(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testc(in BitMatrix16 A)
            => BitBlocks.testc(in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testc(in BitMatrix16 A, in BitMatrix16 M)
            => BitBlocks.testc(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testc(in BitMatrix32 A)
            => BitBlocks.testc(in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testc(in BitMatrix32 A, in BitMatrix32 M)
            => BitBlocks.testc(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testc(in BitMatrix64 A)
            => BitBlocks.testc(in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are enabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testc(in BitMatrix64 A, in BitMatrix64 M)
            => BitBlocks.testc(in A.Head, in M.Head);
    }

}