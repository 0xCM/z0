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

    public readonly struct Dynops : IDynops
    {
        public static IDynops Services => default(Dynops);
    }   

    public interface IDynops : IStatelessFactory<Dynops>
    {
        IDynexus Nexus => Dynexus.Create(StatelessIdentity.Factory.Diviner);
    }
}