//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Spans
    {
        /// <summary>
        /// Enables bytespan execution
        /// </summary>
        /// <param name="src">The executable code</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> liberate(Span<byte> src)
        {
            Buffers.liberate(src);        
            return src;
        }
    }
}