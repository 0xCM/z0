//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TKindServices
    {
        IIdentityProducer IdentityProducer 
            => Z0.IdentityProducer.Service;
        
        IIdentityReflector IdentityReflector 
            => Z0.IdentityReflector.Service;

        IIdentityParser IdentityParser 
            => OpIdentityParser.Service;
    }   
}