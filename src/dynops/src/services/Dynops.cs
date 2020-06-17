//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Dynops : IDynops
    {
        public static IDynops Services => default(Dynops);
    }   

    public interface IDynops : IStateless<Dynops>
    {
        IDynexus Dynexus => new Dynexus(Identities.Services.Diviner);
    }
}