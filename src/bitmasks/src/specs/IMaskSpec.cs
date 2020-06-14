//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMaskSpec : ITextual
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

        string ITextual.Format()
            => $"lsb(f:{Typed.value<F>()}, d:{Typed.value<D>()}, t:{typeof(T).NumericKind().Format()})";        
    }

}