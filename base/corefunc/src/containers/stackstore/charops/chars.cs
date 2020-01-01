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
        /// Allocates a 2-character storage stack
        /// </summary>
        /// <param name="n">The character count</param>
        [MethodImpl(Inline)]
        public static CharStack2 chars(N2 n)
            => default;

        /// <summary>
        /// Allocates a 4-character storage stack
        /// </summary>
        /// <param name="n">The character count</param>
        [MethodImpl(Inline)]
        public static CharStack4 chars(N4 n)
            => default;

        /// <summary>
        /// Allocates an 8-character storage stack
        /// </summary>
        /// <param name="n">The character count</param>
        [MethodImpl(Inline)]
        public static CharStack8 chars(N8 n)
            => default;

        /// <summary>
        /// Allocates a 16-character storage stack
        /// </summary>
        /// <param name="n">The character count</param>
        [MethodImpl(Inline)]
        public static CharStack16 chars(N16 n)
            => default;

        /// <summary>
        /// Allocates a 32-character storage stack
        /// </summary>
        /// <param name="n">The character count</param>
        [MethodImpl(Inline)]
        public static CharStack32 chars(N32 n)
            => default;

        /// <summary>
        /// Allocates a 64-character storage stack
        /// </summary>
        /// <param name="n">The character count</param>
        [MethodImpl(Inline)]
        public static CharStack64 chars(N64 n)
            => default;
    }

}