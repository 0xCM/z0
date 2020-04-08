//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
[assembly: PartId(PartId.BitCore)]

namespace Z0.Parts
{        
    public sealed class BitCore : Part<BitCore>
    {
        
    }
}

namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Seed;

    [ApiHost("bits",ApiHostKind.Direct)]
    public static partial class Bits { }

    [ApiHost(ApiHostKind.Generic)]
    public static partial class gbits 
    {
        [MethodImpl(Inline)]
        static int bitsize<T>()
            where T : unmanaged
                => BitSize.measure<T>();

     }

    public static partial class XBits { }    

    [ApiHost]
    public static partial class BitMask { }       
}