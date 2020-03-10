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

    [OpSvcHostProvider("bitcore.services")]
    public partial class BitCoreServices : IOpSvcHostProvider
    {
        public Type[] ServiceHostTypes {get;}
            = typeof(BitCoreServices).GetNestedTypes().Realize<IFunc>().ToArray();
    }
}