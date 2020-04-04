//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;    

    /// <summary>
    /// Characterizes a bitfield defined over a numeric value
    /// </summary>
    /// <typeparam name="T">The numeric type</typeparam>
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
}