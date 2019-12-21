//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {                       

        [MethodImpl(Inline)]
        public static T replicate<T>(T src, int? from = null, int? to = null, int? reps = null)
            where T : unmanaged
        {
            var i0 = from ?? 0;
            var i1 = to ?? msbpos(src);
            var count = reps ?? (bitsize<T>() / (i1 - i0 + 1) +  1);
            var replicated = Bits.replicate(convert<T,ulong>(src), i0, i1, count);
            return convert<T>(replicated);
        }
    }
}