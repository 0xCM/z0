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
        public static void vperm8x32<T>(in ConstBlock256<T> x, ConstBlock256<uint> y, in Block256<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vperm8x32(x.LoadVector(i), y.LoadVector(i)), ref dst.BlockRef(i));                             
        } 

        [MethodImpl(Inline)]
        public static void vperm2x128<T>(in ConstBlock256<T> x, ConstBlock256<T> y, Perm2x4 spec, in Block256<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vperm2x128(x.LoadVector(i), y.LoadVector(i), spec), ref dst.BlockRef(i));                             
        } 
    }
}