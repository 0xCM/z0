//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Numerics;
    
    using static zfunc;        
    

    partial class math
    {

       [MethodImpl(Inline)]
        public static sbyte square(sbyte src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static byte square(byte src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static short square(short src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static ushort square(ushort src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static int square(int src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static uint square(uint src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static long square(long src)
            => (long)Math.Sqrt(src);

        [MethodImpl(Inline)]
        public static ulong square(ulong src)
            => mul(src,src);

                 
        [MethodImpl(Inline)] 
        public static ref sbyte square(ref sbyte src)
        {
            src *= src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte square(ref byte src)
        {
            src *= src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short square(ref short src)
        {
            src *= src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort square(ref ushort src)
        {
            src *= src;
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref int square(ref int src)
        {
            src *= src;
            return ref src;
        }


        [MethodImpl(Inline)]
        public static ref uint square(ref uint src)
        {
            src *= src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long square(ref long src)
        {
            src *= src;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong square(ref ulong src)
        {
            src *= src;
            return ref src;
        }


    }
}