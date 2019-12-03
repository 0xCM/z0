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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
     
    using static As;
    using static zfunc;

    partial class dinx
    {                
        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vmovblock(in ConstBlock16<byte> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVSXBQ xmm, m16
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vmovblock(in ConstBlock16<sbyte> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVSXBD xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vmovblock(in ConstBlock32<sbyte> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        ///  VPMOVSXBQ ymm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vmovblock(in ConstBlock32<sbyte> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vmovblock(in ConstBlock32<byte> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVSXWQ xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vmovblock(in ConstBlock32<short> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vmovblock(in ConstBlock32<ushort> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vmovblock(in ConstBlock32<byte> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vmovblock(in ConstBlock64<ushort> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVSXBW xmm, m64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vmovblock(in ConstBlock64<sbyte> src, out Vector128<short> dst)
        {
            dst = ConvertToVector128Int16(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vmovblock(in ConstBlock64<byte> src, out Vector128<short> dst)
        {
            dst = ConvertToVector128Int16(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vmovblock(in ConstBlock64<short> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVSXDQ xmm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vmovblock(in ConstBlock64<int> src, out Vector128<long> dst)
        {
           dst = ConvertToVector128Int64(constptr(in src.Head));
           return dst;
        }

        /// <summary>
        ///  VPMOVSXBD ymm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vmovblock(in ConstBlock64<sbyte> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVZXDQ xmm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vmovblock(in ConstBlock64<uint> src, out Vector128<long> dst)
        {
           dst = ConvertToVector128Int64(constptr(in src.Head));
           return dst;
        }

        /// <summary>
        /// VPMOVSXBW ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<short> vmovblock(in ConstBlock128<sbyte> src, out Vector256<short> dst)
        {
            dst = ConvertToVector256Int16(constptr(in src.Head));
            return dst;
        }


        /// <summary>
        /// VPMOVSXDQ ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vmovblock(in ConstBlock128<int> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(constptr(in src.Head));
            return dst;
        }


        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]        
        public static unsafe Vector256<short> vmovblock(in ConstBlock128<byte> src, out Vector256<short> dst)
        {
            dst = ConvertToVector256Int16(constptr(in src.Head));
            return dst;
        }


        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vmovblock(in ConstBlock128<uint> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(constptr(in src.Head));
            return dst;
        }


        /// <summary>
        /// VPMOVSXWD ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vmovblock(in ConstBlock128<short> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vmovblock(in ConstBlock128<ushort> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock32<byte> src, out Vector128<long> lo, out Vector128<long> hi)
        {
            lo = ConvertToVector128Int64(constptr(in src.Head));
            hi = ConvertToVector128Int64(constptr(in skip(in src.Head, 2)));            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock256<ushort> src, out Vector256<int> lo, out Vector256<int> hi)
        {
            vmovblock(src.LoBlock(0), out lo);
            vmovblock(src.HiBlock(0), out hi);
        }
    }
}