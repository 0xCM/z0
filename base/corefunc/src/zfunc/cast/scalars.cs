//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;    
using System.Runtime.Intrinsics;    

using Z0;

partial class zfunc
{


    [MethodImpl(Inline)]
    public static byte uint8<T>(T src)
        => Unsafe.As<T,byte>(ref src);

    [MethodImpl(Inline)]
    public static byte? uint8<T>(T? src)
        where T : unmanaged
            => Unsafe.As<T?, byte?>(ref src);
}