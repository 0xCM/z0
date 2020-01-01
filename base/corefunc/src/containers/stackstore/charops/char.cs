//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static Stacked;

    partial class Stacks
    {
        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack2 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack4 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack8 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack16 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack32 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);

        /// <summary>
        /// Queries/manipulates a index-identified character in a storage stack
        /// </summary>
        /// <param name="src">The character storage</param>
        /// <param name="index">The character index</param>
        [MethodImpl(Inline)]
        public static ref char @char(ref CharStack64 src, int index)
            => ref Unsafe.Add(ref chead(ref src), index);
    }
}