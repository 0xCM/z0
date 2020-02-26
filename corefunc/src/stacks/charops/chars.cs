//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static Stacked;
    using static P2K;

    partial class Stacks
    {
       /// <summary>
       /// Allocates a 2-character storage stack
       /// </summary>
       [MethodImpl(Inline)]
       public static CharStack2 chars(P2x1 p2)
            => default;

        /// <summary>
        /// Allocates a 4-character storage stack
        /// </summary>
        [MethodImpl(Inline)]
        public static CharStack4 chars(P2x2 p2)
            => default;

        /// <summary>
        /// Allocates an 8-character storage stack
        /// </summary>
        [MethodImpl(Inline)]
        public static CharStack8 chars(P2x3 p2)
            => default;

        /// <summary>
        /// Allocates a 16-character storage stack
        /// </summary>
        [MethodImpl(Inline)]
        public static CharStack16 chars(P2x4 p2)
            => default;

        /// <summary>
        /// Allocates a 32-character storage stack
        /// </summary>
        [MethodImpl(Inline)]
        public static CharStack32 chars(P2x5 p2)
            => default;

        /// <summary>
        /// Allocates a 64-character storage stack
        /// </summary>
        [MethodImpl(Inline)]
        public static CharStack64 chars(P2x6 p2)
            => default;


    }

}