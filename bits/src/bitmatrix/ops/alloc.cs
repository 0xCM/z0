//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static BitMatrix<T> load<T>(Span<T> rows)
            where T : unmanaged
                => new BitMatrix<T>(rows);

        [MethodImpl(NotInline)]
        public static BitMatrix<T> alloc<T>()
            where T : unmanaged
                => new BitMatrix<T>(new Span<T>(new T[BitMatrix<T>.N]));

        /// <summary>
        /// Allocates a bitmatrix filled with specified content
        /// </summary>
        /// <param name="row">The row content source</param>
        /// <typeparam name="T">The matrix primal type</typeparam>
        [MethodImpl(NotInline)]
        public static BitMatrix<T> fill<T>(BitVector<T> row)
            where T : unmanaged
                => new BitMatrix<T>(row);

        [MethodImpl(NotInline)]
        public static void alloc<T>(out BitMatrix<T> dst)
            where T : unmanaged
                => dst = new BitMatrix<T>(new Span<T>(new T[BitMatrix<T>.N]));

        [MethodImpl(NotInline)]
        public static BitMatrix8 alloc(N8 n, bit fill = default)
            => BitMatrix8.Alloc(fill);

        [MethodImpl(NotInline)]
        public static BitMatrix16 alloc(N16 n, bit fill = default)
            => BitMatrix16.Alloc(fill);

        [MethodImpl(NotInline)]
        public static BitMatrix32 alloc(N32 n, bit fill = default)
            => BitMatrix32.Alloc(fill);

        [MethodImpl(NotInline)]
        public static BitMatrix64 alloc(N64 n, bit fill = default)
            => BitMatrix64.Alloc(fill);


        [MethodImpl(Inline)]
        public static BitMatrix<T> from<T>(RowBits<T> src)
            where T : unmanaged
        {
            if(src.RowCount != bitsize<T>())
                Errors.Throw($"{bitsize<T>()} != {src.RowCount}");

            return load(src.data);                
        }
    }

}