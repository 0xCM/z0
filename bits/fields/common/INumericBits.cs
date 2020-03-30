//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;

    public interface IIndexedBits<F> : IBitField
        where F : unmanaged, Enum
    {

    }

    public interface INumericBits<T> : IBitField
        where T : unmanaged
    {
        T Data {get;set;}

        int IBitField.TotalWidth
        {
            [MethodImpl(Inline)]
            get => bitsize<T>();
        }
    }

    public interface INumericBits<S,T> : INumericBits<T>, INumericFormatProvider<T>
        where T : unmanaged
        where S : INumericBits<T>
    {        
    }
}