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
        /// 16x8[0 1] -> 128x64:[0 1]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vmovblock(in ConstBlock16<byte> src, out Vector128<ulong> dst)
        {
            dst = v64u(ConvertToVector128Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 32x8:[0 1 2 3] -> 128x4:[0 1 2 3]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmovblock(in ConstBlock32<byte> src, out Vector128<uint> dst)
        {
            dst = v32u(ConvertToVector128Int32(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 32x8:[0 1 2 3] -> 256x64:[0 1 2 3]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmovblock(in ConstBlock32<byte> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// 32x16:[0 1] -> 128x64[0 1]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vmovblock(in ConstBlock32<ushort> src, out Vector128<ulong> dst)
        {
            dst = v64u(ConvertToVector128Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 64x8:[0 1 2 3 4 5 6 7] -> 128x16:[0 1 2 3 4 5 6 7]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vmovblock(in ConstBlock64<byte> src, out Vector128<ushort> dst)
        {
            dst = v16u(ConvertToVector128Int16(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 64x16:[0 1 2 3] -> 128x32:[0 1 2 3]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmovblock(in ConstBlock64<ushort> src, out Vector128<uint> dst)
        {
            dst = v32u(ConvertToVector128Int32(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 64x8:[0 1 2 3 4 5 6 7] -> 256x32:[0 1 2 3 4 5 6 7]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vmovblock(in ConstBlock64<byte> src, out Vector256<uint> dst)
        {
            dst = v32u(ConvertToVector256Int32(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 64x16:[0 1 2 3] -> 256x64:[0 1 2 3]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmovblock(in ConstBlock64<ushort> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            return dst;
        }


        /// <summary>
        /// PMOVZXDQ xmm, m64
        /// 64x32:[0 1] -> 128x64:[0 1]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vmovblock(in ConstBlock64<uint> src, out Vector128<ulong> dst)
        {
           dst = v64u(ConvertToVector128Int64(constptr(in src.Head)));
           return dst;
        }

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 128x8:[0 1 2 3 4 5 6 7 8 9 A B C D E F] -> 256x16:[0 1 2 3 4 5 6 7 8 9 A B C D E F]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vmovblock(in ConstBlock128<byte> src, out Vector256<ushort> dst)
        {
            dst = v16u(ConvertToVector256Int16(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 128x16[0 1 2 3 4 5 6 7] -> 256x32:[0 1 2 3 4 5 6 7]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vmovblock(in ConstBlock128<ushort> src, out Vector256<uint> dst)
        {
            dst = v32u(ConvertToVector256Int32(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 128x32:[0 1 2 3] -> 256x4:[0 1 2 3]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmovblock(in ConstBlock128<uint> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// 32x8[0 1 2 3] -> (128x64:[0 1],128x64:[2 3])
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock32<byte> src, out Vector128<ulong> lo, out Vector128<ulong> hi)
        {
            vmovblock(src.LoBlock(0), out lo);
            vmovblock(src.HiBlock(0), out hi);                
        }

        /// <summary>
        /// 64x8[0 1 2 3 4 5 6 7] -> (128x4:[0 1 2 3], 128x4:[4 5 6 7])
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static void vmovblock(in ConstBlock64<byte> src, out Vector128<uint> x0, out Vector128<uint> x1)
        {
            vmovblock(src.LoBlock(0), out x0);
            vmovblock(src.HiBlock(0), out x1);
        }            

        /// <summary>
        /// 128x8:[0 1 2 3 4 5 6 7 8 9 A B C D E F] -> (128x16:[0 1 2 3 4 5 6 7], 128x16:[8 9 A B C D E F])
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static void vmovblock(in Block128<byte> src, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {
            vmovblock(src.LoBlock(0), out lo);
            vmovblock(src.HiBlock(0), out hi);
        }            

        /// <summary>
        /// 256x8:[0 1 ... E F 10 11 .. 1E 1F] -> (256x16:[0 1 ... E F], 256x16:[0 1 ... E F])
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock256<byte> src, out Vector256<ushort> lo, out Vector256<ushort> hi)
        {
            vmovblock(src.LoBlock(0), out lo);
            vmovblock(src.HiBlock(0), out hi);
        }

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 128x16:[0 1 2 3 4 5 6 7] -> (256x64:[0 1 2 3], 256x64:[4 5 6 7]
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock128<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            vmovblock(src.LoBlock(0), out lo);
            vmovblock(src.HiBlock(0), out hi);
        }

        /// <summary>
        /// 256x32:[0 1 2 3 4 5 6 7] -> (256x64:[0 1 2 3], 256x64:[4 5 6 7])
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            vmovblock(src.LoBlock(0), out lo);
            vmovblock(src.HiBlock(0), out hi);
        }

        /// <summary>
        /// 256x16[0 1 2 3 4 5 6 7 8 9 A B C D E F] -> (256x32:[0 1 2 3 4 5 6 7], 256x32:[8 9 A B C D E F])
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock256<ushort> src, out Vector256<uint> lo, out Vector256<uint> hi)
        {
            vmovblock(src.LoBlock(0), out lo);
            vmovblock(src.HiBlock(0), out hi);
        }

    }
}