//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Runtime.CompilerServices;

    using static Seed;

    using Svc = Z0;

    public interface IStatelessSeed : IStatelessFactory<StatelessSeed>
    {
        IPartParser PartParser => Svc.PartParser.Service;   

        IPartIndexBuilder PartIndexBuilder => Svc.PartIndexBuilder.Service;     
    }

    public readonly struct StatelessSeed : IStatelessSeed
    {
        public static IStatelessSeed Fatory => default(StatelessSeed);
    }
}