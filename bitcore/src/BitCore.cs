//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Seed;

    [ApiHost("api")]
    public partial class Bits : IApiHost<Bits>
    {

    }

    [ApiHost]
    public partial class gbits : IApiHost<gbits>
    {

    }

    [ApiHost]
    public partial class BitMask : IApiHost<BitMask>
    {

    }       
    
    [ApiHost, ApiServiceProvider]
    public partial class BitService : IApiServiceProvider<BitService>
    {

    }

    public partial class BitMasks
    {            

    }

    public static partial class XTend
    {

    }
    
    public static partial class XBits 
    { 
        
    }    
}