//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IBitFrequency
    {
        uint F {get;}
    }

    public interface IBitFrequency<F> : IBitFrequency
        where F : unmanaged, ITypeNat
    {
        F f => default;
    }
}