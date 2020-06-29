//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static Memories;

    partial class BitFields
    {        
        [MethodImpl(Inline)]
        public static string format(ReadOnlySpan<BitFieldSegment> src)
            => BitFieldSegmentFormatter.format<BitFieldSegment,byte>(src);

        [MethodImpl(Inline)]
        public static string format<T>(ReadOnlySpan<BitFieldSegment<T>> src)
            where T : unmanaged
                => BitFieldSegmentFormatter.format<BitFieldSegment<T>,T>(src);
    }
}