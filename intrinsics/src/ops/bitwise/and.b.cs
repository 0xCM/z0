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
    using static As;
    
    partial class ginx
    {
        [MethodImpl(Inline)]
        public static void vblend32x8<T>(in ConstBlock256<T> xb, in ConstBlock256<T> yb, in ConstBlock256<byte> zb, in Block256<T> dst)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block=0; block< count; block++)
                vstore(ginx.vblend(xb.LoadVector(block), yb.LoadVector(block), zb.LoadVector(block)), ref dst.BlockRef(block));                             
        } 

        [MethodImpl(Inline)]
        public static void vand<T>(in ConstBlock128<T> xb, in ConstBlock128<T> yb, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vand(xb.LoadVector(block), yb.LoadVector(block)), ref zb.BlockRef(block));
        } 

        [MethodImpl(Inline)]
        public static void vand<T>(in ConstBlock256<T> xb, in ConstBlock256<T> yb, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vand(xb.LoadVector(block), yb.LoadVector(block)), ref zb.BlockRef(block));
        } 

    }

}