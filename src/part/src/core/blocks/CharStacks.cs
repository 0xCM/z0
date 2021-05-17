//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct CharStacks
    {
        public struct CharStack2
        {
            public char C0;

            char C1;
        }

        public struct CharStack4
        {
            public CharStack2 C0;

            CharStack2 C1;
        }

        public struct CharStack8
        {
            public CharStack4 C0;

            CharStack4 C1;
        }

        public struct CharStack16
        {
            public CharStack8 C0;

            CharStack8 C1;
        }

        public struct CharStack32
        {
            public CharStack16 C0;

            CharStack16 C1;
        }

        public struct CharStack64
        {
            public CharStack32 C0;

            CharStack32 C1;
        }

        /// <summary>
        /// Allocates a 2-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack2 alloc(N2 n)
            => default;

        /// <summary>
        /// Allocates a 4-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack4 alloc(N4 n)
            => default;

        /// <summary>
        /// Allocates an 8-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack8 alloc(N8 n)
            => default;

        /// <summary>
        /// Allocates a 16-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack16 alloc(N16 n)
            => default;

        /// <summary>
        /// Allocates a 32-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack32 alloc(N32 n)
            => default;

        /// <summary>
        /// Allocates a 64-character storage stack
        /// </summary>
        [MethodImpl(Inline), Op]
        public static CharStack64 alloc(N64 n)
            => default;
        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack2 src)
            => cover(first(ref src), 2);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack4 src)
            => cover(first(ref src), 4);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack8 src)
            => cover(first(ref src), 8);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack16 src)
            => cover(first(ref src), 16);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack32 src)
            => cover(first(ref src), 32);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack64 src)
            => cover(first(ref src), 64);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack2 src)
            => ref src.C0;

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack4 src)
            => ref c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack8 src)
            => ref c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack16 src)
            => ref c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack32 src)
            => ref c16(src);

        /// <summary>
        /// Retrieves a reference to the leading character storage cell
        /// </summary>
        /// <param name="src">The character storage source</param>
        [MethodImpl(Inline), Op]
        public static ref char first(ref CharStack64 src)
            => ref c16(src);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack2 src, int index)
            => ref add(first(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack4 src, int index)
            => ref add(first(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack8 src, int index)
            => ref add(first(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack16 src, int index)
            => ref add(first(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack32 src, int index)
            => ref add(first(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline), Op]
        public static ref char cell(ref CharStack64 src, int index)
            => ref add(first(ref src), index);
    }
}