//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IKindServices : IStatelessFactory<KindsApi>
    {
        IdentityProducer IdentityProducer => new IdentityProducer();
        
        IReflectiveClass ReflectiveClass => new ReflectiveClass();
    }
 
    public interface IKindOps 
    {

    }

    public readonly struct KindsApi : IKindOps, IKindServices
    {
        public static IKindOps Ops => default(KindsApi);

        public static IKindServices Services => default(KindsApi);
    }
}