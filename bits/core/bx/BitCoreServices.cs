//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static Root;

    [ApiServiceHostProvider("bitcore.services")]
    public partial class BitCoreServices : IApiServiceHosts
    {
        public Type[] HostTypes {get;}
            = typeof(BitCoreServices).GetNestedTypes().Realize<ISFuncApi>().ToArray();
    }
}