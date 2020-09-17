//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using I = ICanonicalKind;
    using K = CanonicalApiKeyKind;

    public interface ICanonicalKind : IOpKind, IOpKind<K>
    {
        K Kind {get;}

        ApiKeyId IOpKind.KindId
            => (ApiKeyId)Kind;
    }

    public interface ICanonicalKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        ApiKeyId IOpKind.KindId
            => default(F).KindId;
    }

    public interface ICanonicalKind<F,T> : ICanonicalKind<F>
        where F : unmanaged, I
    {
        K I.Kind
            => default(F).Kind;
    }
}