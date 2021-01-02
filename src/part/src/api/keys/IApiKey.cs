//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IApiKey : ITextual
    {
        ApiClass Id {get;}

        string ITextual.Format()
            => Id.ToString().ToLower();
    }

    /// <summary>
    /// Characterizes a subkey group
    /// </summary>
    /// <typeparam name="G">The group key kind</typeparam>
    [Free]
    public interface IApiKey<G> : IApiKey
        where G : unmanaged, Enum
    {
        new G Id {get;}

        ApiClass IApiKey.Id
            => (ApiClass)EnumValue.e16u(Id);
    }

    /// <summary>
    /// Characterizes a reified subkey group
    /// </summary>
    /// <typeparam name="G">The group key kind</typeparam>
    [Free]
    public interface IApiKey<H,G> : IApiKey<G>
        where G : unmanaged, Enum
        where H : unmanaged, IApiKey<H,G>
    {

    }
}