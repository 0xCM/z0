//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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
    public interface IApiKey<G> : IApiKey
        where G : unmanaged, Enum
    {
        new G Id {get;}

        ApiKeyId IApiKey.Id
            => (ApiKeyId)Enums.e16u(Id);
    }

    public interface IOpKind<E> : IApiKey, ILiteralKind<E>
        where E : unmanaged, Enum
    {
        E ITypedLiteral<E>.Class
            => default;
    }

    public interface IOpKind<K,E> : IOpKind<E>
        where E : unmanaged, Enum
        where K : unmanaged, IOpKind<E>
    {
        K Kind => default;
    }
}