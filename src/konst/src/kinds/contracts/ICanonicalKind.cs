//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using I = ICanonicalKind;
    using K = CanonicalOpId;

    public interface ICanonicalKind : IOpKind, IOpKind<K>
    {
        K Kind {get;}

        ApiOpId IOpKind.KindId
            => (ApiOpId)Kind;
    }

    public interface ICanonicalKind<F> : I, IOpKind<F,K>
        where F : unmanaged, I
    {
        ApiOpId IOpKind.KindId
            => default(F).KindId;
    }

    public interface ICanonicalKind<F,T> : ICanonicalKind<F>
        where F : unmanaged, I
    {
        K I.Kind
            => default(F).Kind;
    }
}