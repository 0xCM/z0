//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [LiteralProvider]
    public readonly struct AsmRegBits
    {
        /// <summary>
        /// The RegisterCode segment position
        /// </summary>
        public const byte IndexField = 0;

        /// <summary>
        /// K: The RegisterClass segment position
        /// </summary>
        public const byte ClassField = 8;

        /// <summary>
        /// W: The RegisterWidth segment position
        /// </summary>
        public const byte WidthField = 16;

        /// <summary>
        /// The maximum number of register classes
        /// </summary>
        public const byte MaxClass = 30;

        /// <summary>
        /// When present, designates the upper half of a given register
        /// </summary>
        public const uint Hi = MaxClass << 1;

        public enum FieldIndex : byte
        {
            /// <summary>
            /// RegisterCode: [0..7]
            /// </summary>
            C = 0,

            /// <summary>
            /// RegisterClass:[8..15]
            /// </summary>
            K = 8,

            /// <summary>
            /// Register width: [16..30]
            /// </summary>
            W = 16,

            /// <summary>
            /// Upper register selection: [31]
            /// </summary>
            H = 31,
        }

        public enum FieldWidth : byte
        {
            C = FieldIndex.K - FieldIndex.C,

            K = FieldIndex.W - FieldIndex.K,

            W = MaxClass - FieldIndex.W,
        }
    }
}