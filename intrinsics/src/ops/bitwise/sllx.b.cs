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
    
    partial class ginx
    {        
        
        [MethodImpl(Inline)]
        public static void vsllx<T>(in ConstBlock128<T> xb, byte shift, in Block128<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vsllx(xb.LoadVector(block), shift), ref dst.BlockRef(block));
        } 

        [MethodImpl(Inline)]
        public static void vsllx<T>(in ConstBlock256<T> xb, byte shift, in Block256<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vsllx(xb.LoadVector(block), shift), ref dst.BlockRef(block));
        } 
    }
}