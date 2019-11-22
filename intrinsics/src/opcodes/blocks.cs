//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    
    
    partial class inxoc
    {                

        public static void xor_block256(ConstBlock256<uint> xs, ConstBlock256<uint> ys, Block256<uint> zs)
            => vblock.xor(xs,ys,zs);

    }

}