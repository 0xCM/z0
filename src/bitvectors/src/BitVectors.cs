//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("api")]
    public partial class BitVector : IApiHost<BitVector>
    {           
        [MethodImpl(Inline)]
        internal static Span<byte> bytes<T>(T src)
            where T : struct
                => Bytes.from(src);
    }

    public static partial class XTend
    {
        
    }    
}