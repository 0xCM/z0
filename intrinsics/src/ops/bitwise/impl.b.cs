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
        public static void vimpl<T>(in ConstBlock128<T> xb, in ConstBlock128<T> yb, in Block128<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vimpl(xb.LoadVector(block), yb.LoadVector(block)), ref dst.BlockRef(block));
        } 

        [MethodImpl(Inline)]
        public static void vimpl<T>(in ConstBlock256<T> xb, in ConstBlock256<T> yb, in Block256<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var block = 0; block < count; block++)
                vstore(ginx.vimpl(xb.LoadVector(block), yb.LoadVector(block)), ref dst.BlockRef(block));
        } 
    }

}