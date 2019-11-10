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
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is defined</typeparam>
        [MethodImpl(Inline)]
        public static bit testz<T>(in BitMatrix<T> A)
            where T : unmanaged
                => BitBlocks.testz(in A.Head, in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        /// <typeparam name="T">The primal type over which the matrix is defined</typeparam>
        [MethodImpl(Inline)]
        public static bit testz<T>(in BitMatrix<T> A, in BitMatrix<T> M)
            where T : unmanaged
                => BitBlocks.testz(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix8 A)
            => BitBlocks.testz(in A.Head, in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix8 A, in BitMatrix8 M)
            => BitBlocks.testz(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix16 A)
            => BitBlocks.testz(in A.Head, in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix16 A, in BitMatrix16 M)
            => BitBlocks.testz(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix32 A)
            => BitBlocks.testz(in A.Head, in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix32 A, in BitMatrix32 M)
            => BitBlocks.testz(in A.Head, in M.Head);

        /// <summary>
        /// Returns true if all bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix64 A)
            => BitBlocks.testz(in A.Head, in A.Head);

        /// <summary>
        /// Returns true if all mask-identified bits in a matrix are disabled, false otherwise
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="M">The mask matrix</param>
        [MethodImpl(Inline)]
        public static bit testz(in BitMatrix64 A, in BitMatrix64 M)
            => BitBlocks.testz(in A.Head, in M.Head);
    }
}