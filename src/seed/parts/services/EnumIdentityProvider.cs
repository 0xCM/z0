// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System; 

    using static Konst;
    
    [IdentityProvider]
    public readonly struct EnumIdentityProvider : ITypeIdentityProvider<EnumIdentityProvider,EnumIdentity>
    {                
        public EnumIdentity Identify(Type src)
            => EnumIdentity.Define(src);

        bool CanIdentify(Type src)
            => src.IsEnum;
    }
}