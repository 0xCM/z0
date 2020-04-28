//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Dynops : IDynops
    {
        public static IDynops Services => default(Dynops);
    }   

    public interface IDynops : IStatelessFactory<Dynops>
    {
        IDynexus Dynexus => new Dynexus(StatelessIdentity.Services.Diviner);
    }
}