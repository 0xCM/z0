//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Ssse3;
        
    using static zfunc;

    partial class dinx    
    {        

        [MethodImpl(Inline)]
        public static Vector256<byte> vperm32x8(Vector256<byte> src, Perm32 spec)
            => vshuf32x8(src,spec.data);


    }

}