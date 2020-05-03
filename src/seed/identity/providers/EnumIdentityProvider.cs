// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System; 
    using System.Linq;   
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    [IdentityProvider]
    public readonly struct EnumIdentityProvider : ITypeIdentityProvider<EnumIdentityProvider,EnumIdentity>
    {                
        public EnumIdentity Identify(Type src)
            => EnumIdentity.Define(src);

        bool CanIdentify(Type src)
            => src.IsEnum;
    }
}