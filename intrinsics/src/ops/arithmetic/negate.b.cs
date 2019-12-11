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
        public static void vnegate<T>(in ConstBlock128<T> x, in Block128<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var block=0; block< count; block++)
                vstore(ginx.vnegate(x.LoadVector(block)), ref dst.BlockRef(block));                             
        } 

        [MethodImpl(Inline)]
        public static void vnegate<T>(in ConstBlock256<T> x, in Block256<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var block=0; block< count; block++)
                vstore(ginx.vnegate(x.LoadVector(block)), ref dst.BlockRef(block));                             
        } 
    }
}