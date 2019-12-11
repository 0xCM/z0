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
        public static void vbsrl<T>(in ConstBlock128<T> xb, byte shift, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vbsrl(xb.LoadVector(block), shift), ref zb.BlockRef(block));
        } 

        [MethodImpl(Inline)]
        public static void vbsrl<T>(in ConstBlock256<T> xb, byte shift, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vbsrl(xb.LoadVector(block), shift), ref zb.BlockRef(block));
        } 
    }
}