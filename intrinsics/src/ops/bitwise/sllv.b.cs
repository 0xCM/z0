//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;
    
    partial class ginx
    {        
        [MethodImpl(Inline)]
        public static void vsllv<T>(in ConstBlock128<T> xb, in ConstBlock128<T> offsets, in Block128<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block=0; block < count; block++)
                vstore(ginx.vsllv(xb.LoadVector(block), offsets.LoadVector(block)), ref zb.BlockRef(block));                             
        } 

        [MethodImpl(Inline)]
        public static void vsllv<T>(in ConstBlock256<T> xb, in ConstBlock256<T> offsets, in Block256<T> zb)
            where T : unmanaged
        {
            var count = zb.BlockCount;
            for(var block=0; block < count; block++)
                vstore(ginx.vsllv(xb.LoadVector(block), offsets.LoadVector(block)), ref zb.BlockRef(block));                             
        } 

    }

}