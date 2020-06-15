//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface ITypeCode
    {
        ulong TypeId {get;}

        Type IdentifiedType {get;}
    }

    public interface ITypeCode<T> : ITypeCode
    {
        Type ITypeCode.IdentifiedType
        {
            [MethodImpl(Inline)]
            get => typeof(T);
        }
    }
}