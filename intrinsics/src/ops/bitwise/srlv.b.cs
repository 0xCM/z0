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
        public static void vsrlv<T>(in ConstBlock128<T> xb, in ConstBlock128<T> offsets, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block=0; block < count; block++)
                vstore(ginx.vsrlv(xb.LoadVector(block), offsets.LoadVector(block)), ref zb.BlockRef(block));                             
        } 

        [MethodImpl(Inline)]
        public static void vsrlv<T>(in ConstBlock256<T> xb, in ConstBlock256<T> offsets, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block=0; block < count; block++)
                vstore(ginx.vsrlv(xb.LoadVector(block), offsets.LoadVector(block)), ref zb.BlockRef(block));                             
        } 
    }
}