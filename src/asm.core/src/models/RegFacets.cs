//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [LiteralProvider]
    public readonly struct RegFacets
    {
        /// <summary>
        /// The RegisterCode segment position
        /// </summary>
        public const byte IndexField = 0;

        /// <summary>
        /// K: The RegisterClass segment position
        /// </summary>
        public const byte ClassField = 5;

        /// <summary>
        /// W: The RegisterWidth segment position
        /// </summary>
        public const byte WidthField = 10;

        /// <summary>
        /// When present, designates the upper half of a given register
        /// </summary>
        public const ushort Hi = 1 << 15;

        public const byte LastXmmIndex = 31;

        public const byte LastYmmIndex = 31;

        public const byte LastZmmIndex = 31;

        public enum FieldIndex : byte
        {
            /// <summary>
            /// RegisterCode: [0..5]
            /// </summary>
            C = IndexField,

            /// <summary>
            /// RegisterClass:[6..9]
            /// </summary>
            K = ClassField,

            /// <summary>
            /// Register width: [10..13]
            /// </summary>
            W = WidthField,

            /// <summary>
            /// Upper register selection: [15]
            /// </summary>
            H = 15,
        }

        public enum FieldWidth : byte
        {
            RegCode = 5,

            RegClass = 4,

            RegWidth = 3,
        }
    }
}