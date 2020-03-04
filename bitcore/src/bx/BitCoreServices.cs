//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static Root;

    [OpServiceProvider("bitcore.services")]
    public partial class BitCoreServices : IOpServiceProvider
    {
        public IEnumerable<Type> ServiceHostTypes 
            => typeof(BitCoreServices).GetNestedTypes().Realize<IFunc>();
    }
}