//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IHexType
    {
        Hex8Kind Value {get;}
    }

    public interface IHexType<H> : IHexType
        where H : unmanaged, IHexType<H>
    {
        Type Reified
        {
            [MethodImpl(Inline)]
            get => typeof(H);
        }
    }
}