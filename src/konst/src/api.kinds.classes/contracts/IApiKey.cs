//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Konst;

    [Free]
    public interface IApiKey : IKind, ITextual
    {
        ApiKeyId Id {get;}

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

        ApiKeyId IApiKey.Id
            => (ApiKeyId)Enums.e16u(Id);
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