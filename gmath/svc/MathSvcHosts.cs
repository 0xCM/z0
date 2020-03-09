//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using Z0.Resolutions;

    [OpServiceFactoryProvider(MathServices.SvcCollectionName)]
    public sealed partial class MathSvcHosts  : OpServiceProvider<MathSvcHosts>
    {
        public const string SvcCollectionName = "math.services";        
    }

}