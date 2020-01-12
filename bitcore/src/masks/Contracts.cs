//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    [Flags]
    public enum MaskKind : uint
    {
        None,

        Lsb = 1,

        Msb = 2,

        Jsb = Lsb | Msb,

        Central = 4,

        Cjsb = Central | Jsb,

        Parity,

        Index = 128,
    }


    public interface IMaskSpec
    {        
        MaskKind M {get;}

        PrimalKind K {get;}

    }

    public interface IBitDensity 
    {
        uint D {get;}   
    }

    public interface IBitDensity<D> : IBitDensity
        where D : unmanaged, ITypeNat
    {
        D d => default;

    }

    public interface IBitFrequency
    {
        uint F {get;}
    }

    public interface IBitFrequency<F> : IBitFrequency
        where F : unmanaged, ITypeNat
    {
        F f => default;

    }

    public interface IMaskSpec<T> : IMaskSpec
        where T : unmanaged
    {

    }

    public interface IMaskSpec<F,D,T> : IMaskSpec<T>, IBitDensity<D>, IBitFrequency<F>  
        where F : unmanaged, ITypeNat
        where D : unmanaged, ITypeNat
        where T : unmanaged
    {
        T t => default;
    }


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