//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface TKindServices
    {
        TIdentityProducer IdentityProducer 
            => Z0.IdentityProducer.Service;
        
        TIdentityReflector IdentityReflector 
            => Z0.IdentityReflector.Service;

        IIdentityParser IdentityParser 
            => OpIdentityParser.Service;
    }   
}