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

    public interface IFixedSeg<F,T> : IFixed        
        where F : unmanaged, IFixed
        where T : struct        
    {
        FixedWidth IFixed.Width => (FixedWidth)bitsize<T>();   
    }

    public interface IFixed<F,W> : IFixed
        where F : unmanaged, IFixed<F,W>
        where W : unmanaged, ITypeNat
    {
        W NatWidth => default;
        
    } 
}