//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Memories;

    public interface IMaskSpec : ICustomFormattable
    {        
        MaskKind M {get;}

        NumericKind K {get;}
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

        string ICustomFormattable.Format()
            => $"lsb(f:{value<F>()}, d:{value<D>()}, t:{typeof(T).NumericKind().Format()})";        
    }

}