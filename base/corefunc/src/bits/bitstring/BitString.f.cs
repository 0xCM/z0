//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

using Z0;

partial class zfunc
{

    [MethodImpl(Inline)]
    public static byte uint8(BitString src)
        => src.Scalar<byte>(0);

    [MethodImpl(Inline)]
    public static BitString bitstring<T>(T src)
        where T : unmanaged
            => BitString.from(src);

}