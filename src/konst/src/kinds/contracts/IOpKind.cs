//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IOpKind : IKind, ITextual
    {
        ApiOpId KindId {get;}

        string ITextual.Format()
            => KindId.ToString().ToLower();
    }

    public interface IOpKind<E> : IOpKind, ILiteralKind<E>
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


    partial class XTend
    {
        [MethodImpl(Inline)]
        public static string Format<K>(this K kind)
            where K : IOpKind
                => kind.Format();
    }
}