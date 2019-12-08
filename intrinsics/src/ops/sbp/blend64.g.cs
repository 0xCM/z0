//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static zfunc;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vector128<T> vblend<T>(Vector128<T> x, Vector128<T> y, Blend2x64 spec)        
            where T : unmanaged
                => vgeneric<T>(dinx.vblend(v64u(x), v64u(y), spec));


        [MethodImpl(Inline)]
        public static Vector256<T> vblend<T>(Vector256<T> x, Vector256<T> y, Blend4x64 spec)        
            where T : unmanaged
                => vgeneric<T>(dinx.vblend(v64u(x), v64u(y), spec));
    }

}