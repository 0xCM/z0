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
        public static void vsll<T>(in ConstBlock128<T> x, byte shift, in Block128<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vsll(x.LoadVector(i), shift), ref dst.BlockRef(i));                             
        } 


        [MethodImpl(Inline)]
        public static void vsll<T>(in ConstBlock256<T> x, byte shift, in Block256<T> dst)
            where T : unmanaged
        {
            var count = dst.BlockCount;
            for(var i=0; i< count; i++)
                vstore(ginx.vsll(x.LoadVector(i), shift), ref dst.BlockRef(i));                             
        } 
    }
}