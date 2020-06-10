//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct KindsApi : IKindOps, IKindServices
    {
        public static IKindOps Ops 
        {
            [MethodImpl(Inline)]
            get => IKindOps.Service();
        }

        public static IKindServices Services 
        {
            [MethodImpl(Inline)]
            get => IKindServices.Service();
        }
    }

    public interface IKindOps : IStateless<KindsApi,IKindOps>
    {

    }

    public interface IKindServices : IStateless<KindsApi,IKindServices>
    {
        IIdentityProducer IdentityProducer 
            => IIdentityProducer.Service();
        
        IIdentityReflector IdentityReflector 
            => IIdentityReflector.Service();

        IIdentityParser IdentityParser 
            => IIdentityParser.Service();
    }   
}