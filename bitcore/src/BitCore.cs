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

    [ApiHost("api")]
    public static partial class Bits { }

    [ApiHost]
    public static partial class gbits 
    {

    }

    public static partial class XTend{}
    
    public static partial class XBits { }    

    [ApiHost]
    public static partial class BitMask { }       

    public static partial class BitMasks
    {            

    }

}