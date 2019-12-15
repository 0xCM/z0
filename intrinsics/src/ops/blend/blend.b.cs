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
        public static void vblend32x8<T>(in ConstBlock256<T> x, in ConstBlock256<T> y, in ConstBlock256<byte> z, in Block256<T> dst)
            where T : unmanaged
        {
            var count = z.BlockCount;
            for(var block=0; block< count; block++)
                vstore(ginx.vblend(x.LoadVector(block), y.LoadVector(block), z.LoadVector(block)), ref dst.BlockRef(block));                             
        } 

    }

}