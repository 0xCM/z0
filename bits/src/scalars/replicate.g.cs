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
            reprange(src, out var i0, out var i1, from, to);
            var count = reps ?? repcount<T>(i0, i1);
            return convert<T>(Bits.replicate(convert<T,ulong>(src), i0, i1, count));
        }

        [MethodImpl(Inline)]
        static void reprange<T>(T src, out int i0, out int i1, int? from = null, int? to = null)
            where T : unmanaged
        {
            i0 = from ?? 0;
            i1 = to ?? msbpos(src);
        }

        [MethodImpl(Inline)]
        static int repwidth(int i0, int i1)
            => i1 - i0 + 1;


        [MethodImpl(Inline)]
        static int repcount<T>(int i0, int i1, int? mod = null)
            where T : unmanaged
                => (mod ?? bitsize<T>()) / repwidth(i0,i1) +  1;

    }

}