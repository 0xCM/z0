//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface ICompositeMask<T>
        where T :unmanaged
    {

    }

    public interface ICompositeMask<F,D,T> : ICompositeMask<T>
        where F : unmanaged, ITypeNat
        where D : unmanaged, ITypeNat
        where T : unmanaged
    {
        IMaskSpec<F,D,T> M1 {get;}

        IMaskSpec<F,D,T> M2 {get;}
    }

    public interface ICompositeMask<F,D1,D2,T> : ICompositeMask<T>
        where F : unmanaged, ITypeNat
        where D1 : unmanaged, ITypeNat
        where D2 : unmanaged, ITypeNat
        where T : unmanaged
    {
        IMaskSpec<F,D1,T> M1 {get;}

        IMaskSpec<F,D2,T> M2 {get;}
    }
}