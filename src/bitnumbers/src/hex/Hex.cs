//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using H = HexCharData;

    [ApiHost]
    public partial class Hex
    {
        /// <summary>
        /// Formats a sequence of primal numeric calls as data-formatted hex
        /// </summary>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static string arrayformat<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => Hex.formatter<T>().Format(src, HexFormatSpecs.HexArray);

        public static MemorySegment[] HexRefs
            => sys.array(memseg(H.UpperSymData), memseg(H.LowerSymData), memseg(H.UpperCodes), memseg(H.LowerCodes));

        const NumericKind Closure = UnsignedInts;
    }
}