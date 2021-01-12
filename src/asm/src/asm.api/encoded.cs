//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        /// <summary>
        /// Defines an encoded instruction from the lower 15 source bytes
        /// </summary>
        /// <param name="src">The encoded data</param>
        [MethodImpl(Inline), Op]
        public static EncodedInstruction encoded(BinaryCode src)
            => new EncodedInstruction(src);
    }
}