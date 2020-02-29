//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;    
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

using Z0;

partial class zfunc
{
    [MethodImpl(Inline)]
    public static void vstore<T>(Vector128<T> src, ref T dst)
        where T : unmanaged
            => vfuncs.vstore(src, ref dst);

    [MethodImpl(Inline)]
    public static void vstore<T>(Vector256<T> src, ref T dst)
        where T : unmanaged
            => vfuncs.vstore(src, ref dst);

    [MethodImpl(Inline)]
    public static Span<T> vstore<T>(Vector128<T> src, Span<T> dst)
        where T : unmanaged            
            => vfuncs.vstore(src, dst);

    [MethodImpl(Inline)]
    public static Span<T> vstore<T>(Vector256<T> src, Span<T> dst)
        where T : unmanaged            
            => vfuncs.vstore(src, dst);
}