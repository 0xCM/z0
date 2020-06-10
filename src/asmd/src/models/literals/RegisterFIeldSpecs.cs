//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    public readonly struct RegisterFieldSpecs
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
    }        
}