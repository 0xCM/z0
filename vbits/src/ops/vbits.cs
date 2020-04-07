//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [ApiHost("api",ApiHostKind.Generic)]
    public static partial class vgbits
    {

    }

    [ApiHost("api.direct",ApiHostKind.Direct)]
    public static partial class vBits
    {

    }

    public partial class vBitSvcHosts
    {        

    }

    [ApiServiceProvider(vBitServices.CollectionName)]
    public partial class vBitServices : IApiServiceProvider<vBitSvcHosts>
    {
        public const string CollectionName = "vbits.services";
    }
}