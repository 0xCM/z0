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
        #region  unsigned

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// Evenly distributes cells from the leading source block across the target
        /// 16x8[0 1] -> 128x64:[0 1]
        /// 2:8 -> 64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vloadblock(in ConstBlock16<byte> src, out Vector128<ulong> dst)
        {
            dst = v64u(ConvertToVector128Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// Evenly distributes cells from the leading source block across the target
        /// 32x8:[0 1 2 3] -> 128x4:[0 1 2 3]
        /// 4:8 -> 32
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vloadblock(in ConstBlock32<byte> src, out Vector128<uint> dst)
        {
            dst = v32u(ConvertToVector128Int32(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// Evenly distributes cells from the leading source block across the target
        /// 32x8:[0 1 2 3] -> 256x64:[0 1 2 3]
        /// 4:8 -> 64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vloadblock(in ConstBlock32<byte> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// Evenly distributes cells from the leading source block across the target
        /// 64x8:[0 1 2 3 4 5 6 7] -> 128x16:[0 1 2 3 4 5 6 7]
        /// 8:8 -> 16
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vloadblock(in ConstBlock64<byte> src, out Vector128<ushort> dst)
        {
            dst = v16u(ConvertToVector128Int16(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// Evenly distributes cells from the leading source block across the target
        /// 64x8:[0 1 2 3 4 5 6 7] -> 256x32:[0 1 2 3 4 5 6 7]
        /// 8:8 -> 32
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vloadblock(in ConstBlock64<byte> src, out Vector256<uint> dst)
        {
            dst = v32u(ConvertToVector256Int32(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// Evenly distributes cells from the leading source block across the target
        /// 128x8:[0 1 2 3 4 5 6 7 8 9 A B C D E F] -> 256x16:[0 1 2 3 4 5 6 7 8 9 A B C D E F]
        /// 16:8 -> 16
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vloadblock(in ConstBlock128<byte> src, out Vector256<ushort> dst)
        {
            dst = v16u(ConvertToVector256Int16(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// Evenly distributes cells from the leading source block across the target
        /// 64x16:[0 1 2 3] -> 256x64:[0 1 2 3]
        /// 4:16 -> 64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vloadblock(in ConstBlock64<ushort> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// Evenly distributes cells from the leading source block across the target
        /// 32x16:[0 1] -> 128x64[0 1]
        /// 2:16 -> 64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vloadblock(in ConstBlock32<ushort> src, out Vector128<ulong> dst)
        {
            dst = v64u(ConvertToVector128Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// Evenly distributes cells from the leading source block across the target
        /// 64x16:[0 1 2 3] -> 128x32:[0 1 2 3]
        /// 4:16 -> 32
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vloadblock(in ConstBlock64<ushort> src, out Vector128<uint> dst)
        {
            dst = v32u(ConvertToVector128Int32(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVZXDQ xmm, m64
        /// Evenly distributes cells from the leading source block across the target
        /// 64x32:[0 1] -> 128x64:[0 1]
        /// 2:32 -> 64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vloadblock(in ConstBlock64<uint> src, out Vector128<ulong> dst)
        {
           dst = v64u(ConvertToVector128Int64(constptr(in src.Head)));
           return dst;
        }


        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// Evenly distributes cells from the leading source block across the target
        /// 128x16[0 1 2 3 4 5 6 7] -> 256x32:[0 1 2 3 4 5 6 7]
        /// 8:16 -> 32
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vloadblock(in ConstBlock128<ushort> src, out Vector256<uint> dst)
        {
            dst = v32u(ConvertToVector256Int32(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// Evenly distributes cells from the leading source block across the target
        /// 128x32:[0 1 2 3] -> 256x4:[0 1 2 3]
        /// 4:32 -> 64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vloadblock(in ConstBlock128<uint> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// Evenly distributes cells from the leading source block across the targets
        /// 32x8[0 1 2 3] -> (128x64:[0 1],128x64:[2 3])
        /// 4:32 -> 64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe void vloadblock(in ConstBlock32<byte> src, out Vector128<ulong> lo, out Vector128<ulong> hi)
        {
            vloadblock(src.LoBlock(0), out lo);
            vloadblock(src.HiBlock(0), out hi);                
        }

        /// <summary>
        /// Evenly distributes cells from the leading source block across the targets
        /// 64x8[0 1 2 3 4 5 6 7] -> (128x4:[0 1 2 3], 128x4:[4 5 6 7])
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static void vloadblock(in ConstBlock64<byte> src, out Vector128<uint> x0, out Vector128<uint> x1)
        {
            vloadblock(src.LoBlock(0), out x0);
            vloadblock(src.HiBlock(0), out x1);
        }            

        /// <summary>
        /// Evenly distributes cells from the leading source block across the targets
        /// 128x8:[0 1 2 3 4 5 6 7 8 9 A B C D E F] -> (128x16:[0 1 2 3 4 5 6 7], 128x16:[8 9 A B C D E F])
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static void vloadblock(in Block128<byte> src, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {
            vloadblock(src.LoBlock(0), out lo);
            vloadblock(src.HiBlock(0), out hi);
        }            

        /// <summary>
        /// Evenly distributes cells from the leading source block across the targets
        /// 256x8:[0 1 ... E F 10 11 .. 1E 1F] -> (256x16:[0 1 ... E F], 256x16:[0 1 ... E F])
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static unsafe void vloadblock(in ConstBlock256<byte> src, out Vector256<ushort> lo, out Vector256<ushort> hi)
        {
            vloadblock(src.LoBlock(0), out lo);
            vloadblock(src.HiBlock(0), out hi);
        }

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// Evenly distributes cells from the leading source block across the targets
        /// 128x16:[0 1 2 3 4 5 6 7] -> (256x64:[0 1 2 3], 256x64:[4 5 6 7])
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe void vloadblock(in ConstBlock128<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            vloadblock(src.LoBlock(0), out lo);
            vloadblock(src.HiBlock(0), out hi);
        }

        /// <summary>
        /// Evenly distributes cells from the leading source block across the targets
        /// 256x32:[0 1 2 3 4 5 6 7] -> (256x64:[0 1 2 3], 256x64:[4 5 6 7])
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe void vloadblock(in ConstBlock256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            vloadblock(src.LoBlock(0), out lo);
            vloadblock(src.HiBlock(0), out hi);
        }

        /// <summary>
        /// Evenly distributes cells from the leading source block across the targets
        /// 256x16[0 1 2 3 4 5 6 7 8 9 A B C D E F] -> (256x32:[0 1 2 3 4 5 6 7], 256x32:[8 9 A B C D E F])
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe void vloadblock(in ConstBlock256<ushort> src, out Vector256<uint> lo, out Vector256<uint> hi)
        {
            vloadblock(src.LoBlock(0), out lo);
            vloadblock(src.HiBlock(0), out hi);
        }

        #endregion

        #region signed

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
        public static unsafe Vector256<int> vloadblock(in ConstBlock128<ushort> src, out Vector256<int> dst)
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
        public static unsafe void vloadblock(in ConstBlock32<byte> src, out Vector128<long> lo, out Vector128<long> hi)
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
            vloadblock(src.LoBlock(0), out lo);
            vloadblock(src.HiBlock(0), out hi);
        }
 

        #endregion

    }
}