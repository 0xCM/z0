//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IOpKind : IKind
    {
        OpKindId KindId {get;}
    }


    public interface IOpKind<E> : IOpKind, ILiteralKind<E>
        where E : unmanaged, Enum
    {
        E ILiftedEnum<E>.Class 
            => Enums.convert<E>(KindId.ToUInt64());

    }

    public interface IOpKind<E,T> : IOpKind<E>, ILiteralKind<E,T>
        where T : unmanaged
        where E : unmanaged, Enum
    {   

    }
}