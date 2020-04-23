//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [ApiHost("api")]
    public static partial class vgbits
    {

    }

    [ApiHost("api.direct")]
    public static partial class vBits
    {

    }

    public partial class VBitSvcTypes
    {        

    }

    [ApiServiceFactory]
    public partial class VBitSvc : IApiService<VBitSvc,VBitSvcTypes>
    {
    
    }
}