//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct KindsApi : IKindOps, IKindServices
    {
        public static IKindOps Ops => IKindOps.Service();

        public static IKindServices Services => IKindServices.Service();
    }

    public interface IKindOps : IStateless<KindsApi,IKindOps>
    {

    }
    public interface IKindServices : IStatelessFactory<KindsApi,IKindServices>
    {
        IIdentityProducer IdentityProducer => IIdentityProducer.Service();
        
        IIdentityReflector IdentityReflector => IIdentityReflector.Service();

        IIdentityParser IdentityParser => IIdentityParser.Service();
    }

    
}