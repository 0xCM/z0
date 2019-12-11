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
        public static void vselect<T>(in ConstBlock128<T> x, in ConstBlock128<T> y, in ConstBlock128<T> z, in Block128<T> dst)
            where T : unmanaged
        {
            var count = z.BlockCount;
            for(var block=0; block< count; block++)
                vstore(ginx.vselect(x.LoadVector(block), y.LoadVector(block), z.LoadVector(block)), ref dst.BlockRef(block));                             
        } 

        [MethodImpl(Inline)]
        public static void vselect<T>(in ConstBlock256<T> x, in ConstBlock256<T> y, in ConstBlock256<T> z, in Block256<T> dst)
            where T : unmanaged
        {
            var count = z.BlockCount;
            for(var block=0; block< count; block++)
                vstore(ginx.vselect(x.LoadVector(block), y.LoadVector(block), z.LoadVector(block)), ref dst.BlockRef(block));                             
        } 
    }
}