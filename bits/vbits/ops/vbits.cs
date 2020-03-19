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

    [ApiServiceHostProvider(vBitServices.CollectionName)]
    public partial class vBitSvcHosts  : ApiServiceHosts<vBitSvcHosts>
    {        

    }

    [ApiSeviceFactoryProvider(CollectionName)]
    public partial class vBitServices : ApiSvcFactoryProvider<vBitServices>
    {
        public const string CollectionName = "vbits.services";
    }
}