//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IScalarBits<T>
        where T : unmanaged
    {
        /// <summary>
        /// The value over which the bitvector is defined
        /// </summary>
        T Scalar {get;}

        TypeWidth Width => width<T>();
    }
}