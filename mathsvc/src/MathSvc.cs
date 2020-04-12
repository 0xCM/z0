//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public sealed partial class MathSvcHosts
    {
    
    }

    [ApiServiceProvider(Parts.MathServices.SvcCollectionName)]
    public partial class MathSvc : IApiServiceProvider<MathSvcHosts>
    {
        public const string SvcCollectionName = "math.services";        
    }

    public static partial class XTend
    {

        
    }
}