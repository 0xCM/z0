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

    [ApiHost("services")]
    public partial class BitFieldServices : IApiHost<BitFieldServices>
    {        
        [MethodImpl(Inline)]
        public static IFormatter<IFieldSegment<T>> SegFormatter<T>()
            where T : unmanaged 
                => default(SegmentFormatter<T>);

        [MethodImpl(Inline)]
        public static IFormatter<S> SegFormatter<S,T>()
            where T : unmanaged
            where S : IFieldSegment<T>
                => default(SegmentFormatter<S,T>);
    }
}