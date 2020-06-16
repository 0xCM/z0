//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Control;

    partial class Spans
    {
        /// <summary>
        /// Enables bytespan execution
        /// </summary>
        /// <param name="src">The executable code</param>
        [MethodImpl(Inline), Op]
        public static unsafe void liberate(Span<byte> src)
            => Buffers.Liberate(src);
    }
}