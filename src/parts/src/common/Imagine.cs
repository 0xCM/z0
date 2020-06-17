//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    /// <summary>
    /// Presents the world as one wishes it to be, though usage could be disastrous if reality and expectation diverge
    /// </summary>
    public readonly struct Imagine
    {
        /// <summary>
        /// Views an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T view<S,T>(in S src)   
            => ref Unsafe.As<S,T>(ref Unsafe.AsRef(src));

        /// <summary>
        /// Transforms a readonly T-cell into an editable T-cell, which may or may not be a good idea
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T edit<T>(in T src)   
            => ref Unsafe.As<T,T>(ref Unsafe.AsRef(src));

        /// <summary>
        /// Transforms a readonly S-cell into an editable T-cell, which may or may not be a good idea
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T edit<S,T>(in S src)   
            => ref Unsafe.As<S,T>(ref Unsafe.AsRef(src));

        /// <summary>
        /// Transforms a readonly S-cell into an editable T-cell, which may or may not be a good idea
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="dst">The target cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T edit<S,T>(in S src, ref T dst)   
            => ref Unsafe.As<S,T>(ref Unsafe.AsRef(src));

        /// <summary>
        /// Envisions an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T envision<S,T>(ref S src)   
            => ref Unsafe.As<S,T>(ref src);

        /// <summary>
        /// Envisions an S-cell as a T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="src">The target cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T envision<S,T>(ref S src, ref T dst)   
            => ref Unsafe.As<S,T>(ref src);

        /// <summary>
        /// Takes a T-cell from an S-cell source
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T take<S,T>(in S src, out T dst)   
        {
            dst = edit<S,T>(src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> span<T>(in T src, int count)
            => MemoryMarshal.CreateReadOnlySpan(ref edit<T>(src), count);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> span<S,T>(in S src, int tCount)
            => MemoryMarshal.CreateReadOnlySpan(ref edit<S,T>(src), tCount);

        /// <summary>
        /// Adds a cell-relative offset to a readonly reference, heh
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="count">The cell offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T add<T>(in T src, int count)
            => ref Unsafe.Add(ref edit(src), count);

        /// <summary>
        /// Increments a cell reference by a unit
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="count">The cell offset count</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T inc<T>(in T src)
            => ref Unsafe.Add(ref edit(src), 1);

        [MethodImpl(Inline)]
        public static ref T add<S,T>(in S src, int tCount)
            => ref Unsafe.Add(ref edit<S,T>(src), tCount);
    }
}