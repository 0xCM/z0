//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Parts;

    public sealed partial class MathSvcHosts
    {
    
    }
    
    [ApiServiceProvider(Parts.MathServices.SvcCollectionName)]
    public partial class MathServices : IApiServiceProvider<MathSvcHosts>
    {
        public const string SvcCollectionName = "math.services";        
    }
}