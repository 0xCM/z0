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
            
        public static ulong sum_256x64u(Vector256<ulong> src)
            => dinx.vsum(src);

        public static ulong sum_256x64u(Vector128<ulong> src)
            => dinx.vsum(src);

        public static void vtranspose(ref Vector128<uint> row0, ref Vector128<uint> row1, ref Vector128<uint> row2, ref Vector128<uint> row3)        
            => dinx.vtranspose(ref row0, ref row1, ref row2, ref row3);

    }

}