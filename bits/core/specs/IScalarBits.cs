//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public interface IScalarBits
    {
        TypeWidth Width {get;}
    }

    public interface IScalarBits<T> : IScalarBits
        where T : unmanaged
    {
        /// <summary>
        /// The value over which the bitvector is defined
        /// </summary>
        T Scalar {get;}

        TypeWidth IScalarBits.Width
        {
           [MethodImpl(Inline)]
           get => width<T>();
        }
    }
}