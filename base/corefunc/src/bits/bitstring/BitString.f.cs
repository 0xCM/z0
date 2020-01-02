//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{

    /// <summary>
    /// Creates a bitstring from a primal scalar value
    /// </summary>
    /// <param name="src">The source value</param>
    /// <typeparam name="T">The primal type</typeparam>
    [MethodImpl(Inline)]
    public static BitString bitstring<T>(T src)
        where T : unmanaged
            => BitString.scalar(src);
}