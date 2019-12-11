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
    
    using static zfunc;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static void vperm8x32<T>(in ConstBlock256<T> xb, ConstBlock256<uint> yb, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vperm8x32(xb.LoadVector(i), yb.LoadVector(i)), ref zb.BlockRef(i));                             
        } 

        [MethodImpl(Inline)]
        public static void vperm2x128<T>(in ConstBlock256<T> xb, ConstBlock256<T> yb, Perm2x4 spec, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vperm2x128(xb.LoadVector(i), yb.LoadVector(i), spec), ref zb.BlockRef(i));                             
        } 
    }
}