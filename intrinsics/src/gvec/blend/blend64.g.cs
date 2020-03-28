//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static Core;
    using static vgeneric;

    partial class gvec
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vblend2x64<T>(Vector128<T> x, Vector128<T> y, [Imm] byte spec)        
            where T : unmanaged
                => generic<T>(dvec.vblend2x64(v64u(x), v64u(y), spec));

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vblend4x64<T>(Vector256<T> x, Vector256<T> y, [Imm] byte spec)        
            where T : unmanaged
                => generic<T>(dvec.vblend4x64(v64u(x), v64u(y), spec));

        [MethodImpl(Inline)]
        public static Vector128<T> vblend<T>(Vector128<T> x, Vector128<T> y, [Imm] Blend2x64 spec)        
            where T : unmanaged
                => generic<T>(dvec.vblend(v64u(x), v64u(y), spec));
    

        [MethodImpl(Inline)]
        public static Vector256<T> vblend<T>(Vector256<T> x, Vector256<T> y, [Imm] Blend4x64 spec)        
            where T : unmanaged
                => generic<T>(dvec.vblend(v64u(x), v64u(y), spec));
    }

}