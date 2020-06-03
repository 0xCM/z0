//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    
    using static Memories;

    partial class BitFields
    {        
        [MethodImpl(Inline)]
        public static string format(ReadOnlySpan<FieldSegment> src)
            => SegmentFormatter.format<FieldSegment,byte>(src);

        [MethodImpl(Inline)]
        public static string format<T>(ReadOnlySpan<FieldSegment<T>> src)
            where T : unmanaged
                => SegmentFormatter.format<FieldSegment<T>,T>(src);
    }
}