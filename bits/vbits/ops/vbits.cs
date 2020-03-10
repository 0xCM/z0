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

    [OpSvcHostProvider(vBitServices.CollectionName)]
    public partial class vBitSvcHosts  : OpSvcHostProvider<vBitSvcHosts>
    {        

    }

    [OpSvcFactoryProvider(CollectionName)]
    public partial class vBitServices : OpSvcFactoryProvider<vBitServices>
    {
        public const string CollectionName = "vbits.services";
    }
}