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

    [OpServiceHostProvider("bitcore.services")]
    public partial class BitCoreServices : IOpServiceHosts
    {
        public Type[] HostTypes {get;}
            = typeof(BitCoreServices).GetNestedTypes().Realize<IFunc>().ToArray();
    }
}