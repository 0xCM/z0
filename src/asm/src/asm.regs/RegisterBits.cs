//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    [LiteralProvider]
    public readonly struct RegisterBits
    {
        /// <summary>
        /// The RegisterCode segment position
        /// </summary>
        public const byte CodeIndex = 0;

        /// <summary>
        /// K: The RegisterClass segment position
        /// </summary>
        public const byte ClassIndex = 8;

        /// <summary>
        /// W: The RegisterWidth segment position
        /// </summary>
        public const byte WidthIndex = 16;

        /// <summary>
        /// The width of the RegisterCode segment
        /// </summary>
        public const byte CodeWidth = 8;

        /// <summary>
        /// The width of the RegisterClass segment
        /// </summary>
        public const byte ClassWidth = 8;

        /// <summary>
        /// The width of the RegisterWidth segment
        /// </summary>
        public const byte WidthWidth = 16;

        /// <summary>
        /// The maximum number of register classes
        /// </summary>
        public const byte MaxClass = 30;

        /// <summary>
        /// When present, designates the upper half of a given register
        /// </summary>
        public const uint Hi = MaxClass << 1;

        public enum FI : byte
        {
            /// <summary>
            /// RegisterCode: [0..3]
            /// </summary>
            C = 0,

            /// <summary>
            /// RegisterClass: [4..15]
            /// </summary>
            K = 4,

            /// <summary>
            /// Register width: [16..30]
            /// </summary>
            W = 16,

            /// <summary>
            /// Upper register selection: [31]
            /// </summary>
            H = 31,
        }

        public enum FW : byte
        {
            C = FI.K - FI.C,

            K = FI.W - FI.K,

            W = MaxClass - FI.W,

            H = FI.H,
        }
    }
}