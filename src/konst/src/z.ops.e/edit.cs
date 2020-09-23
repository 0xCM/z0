//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct z
    {
        /// <summary>
        /// Reveals the character data identified by a string reference as a mutable span
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<char> edit(in StringRef src)
            => cover<char>(src.Address.Pointer<char>(), (uint)src.Length);

        /// <summary>
        /// Transforms a readonly T-cell into an editable T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T edit<T>(in T src)
            => ref AsRef(src);

        /// <summary>
        /// Are you sure you want to do this?
        /// </summary>
        /// <param name="src">The immutable, and possibly interned string that were are going to modify</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref char edit(string src)
            => ref @ref(pchar(src));

        /// <summary>
        /// Covers the content of a readonly span with an editable span
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="count">The number of source cells to read</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <returns>Obviously, this trick could be particularly dangerous</returns>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> edit<T>(ReadOnlySpan<T> src)
            =>  cover(edit(first(src)), src.Length);

        /// <summary>
        /// Transforms a readonly S-cell into an editable T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T edit<S,T>(in S src)
            => ref As<S,T>(ref AsRef(src));

        /// <summary>
        /// Transforms a readonly S-cell into an editable T-cell
        /// </summary>
        /// <param name="src">The source cell</param>
        /// <param name="dst">The target cell</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T edit<S,T>(in S src, ref T dst)
            => ref As<S,T>(ref AsRef(src));
    }
}