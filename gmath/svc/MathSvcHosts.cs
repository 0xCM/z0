//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Resolutions;

    [ApiServiceHostProvider(MathServices.SvcCollectionName)]
    public sealed partial class MathSvcHosts  : ApiServiceHosts<MathSvcHosts>
    {
        public const string SvcCollectionName = "math.services";        
    }
}