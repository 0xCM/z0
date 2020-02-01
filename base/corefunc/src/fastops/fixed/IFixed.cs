//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public interface IFixed
    {
        FixedWidth Width {get;}
    }

    public interface IFixed<W> : IFixed
        where W : unmanaged, ITypeNat
    {
        W NatWidth => default;
    }

    public interface IFixed<F,W> : IFixed<W>
        where F : unmanaged, IFixed<F,W>
        where W : unmanaged, ITypeNat
    {
        
    }
}