//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct Dynops : TDynops
    {
        public static TDynops Services => default(Dynops);
    }   

    public interface TDynops
    {
        IDynexus Dynexus => new Dynexus(Identities.Services.Diviner);
    }
}