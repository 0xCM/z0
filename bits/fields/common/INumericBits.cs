//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;    

    public interface IIndexedBits<F> : IBitField
        where F : unmanaged, Enum
    {

    }

    public interface IScalarField<T> : IBitField, IScalarBits<T>
        where T : unmanaged
    {
        new T Scalar {get;set;}
        
        int IBitField.TotalWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<T>();            
        }

        T IScalarBits<T>.Scalar
            => Scalar;
    }

    public interface IScalarField<S,T> : IScalarField<T>, INumericFormatProvider<T>
        where T : unmanaged
        where S : IScalarField<T>
    {        
    }
}