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
    using static ginx;
    
    partial class vblock
    {     
        [MethodImpl(Inline)]
        public static void shuf16x8<T>(in ConstBlock128<T> xb, ConstBlock128<byte> yb, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vshuf16x8(xb.LoadVector(i), yb.LoadVector(i)), ref zb.BlockRef(i));                             
        } 

        [MethodImpl(Inline)]
        public static void shuf16x8<T>(in ConstBlock256<T> xb, ConstBlock256<byte> yb, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vshuf16x8(xb.LoadVector(i), yb.LoadVector(i)), ref zb.BlockRef(i));                             
        } 
    }
}