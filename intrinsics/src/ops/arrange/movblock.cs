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
        /// PMOVSXBW xmm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vmovblock(in ConstBlock64<sbyte> src, out Vector128<short> dst)
        {
            dst = ConvertToVector128Int16(constptr(in src.Head));
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
        /// PMOVSXBQ xmm, m16
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vmovblock(in ConstBlock32<sbyte> src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(constptr(in src.Head));
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
        /// PMOVZXBW xmm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vmovblock(in ConstBlock64<byte> src, out Vector128<ushort> dst)
        {
            dst = v16u(ConvertToVector128Int16(constptr(in src.Head)));
            return dst;
        }

        [MethodImpl(Inline)]
        public static void vmovblock(in Block128<byte> src, out Vector128<ushort> lo, out Vector128<ushort> hi)
        {
            vmovblock(src.LoBlock(0), out lo);
            vmovblock(src.HiBlock(0), out hi);
        }            

        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock32<byte> src, out Vector128<long> lo, out Vector128<long> hi)
        {
            lo = ConvertToVector128Int64(constptr(in src.Head));
            hi = ConvertToVector128Int64(constptr(in skip(in src.Head, 2)));            
        }

        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock32<byte> src, out Vector128<ulong> lo, out Vector128<ulong> hi)
        {
            lo = v64u(ConvertToVector128Int64(constptr(in src.Head)));
            hi = v64u(ConvertToVector128Int64(constptr(in skip(in src.Head, 2))));            
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
        /// PMOVZXBD xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vmovblock(in ConstBlock32<byte> src, out Vector128<uint> dst)
        {
            dst = v32u(ConvertToVector128Int32(constptr(in src.Head)));
            return dst;
        }

        [MethodImpl(Inline)]
        public static void vmovblock(in ConstBlock64<byte> src, out Vector128<uint> x0, out Vector128<uint> x1)
        {
            vmovblock(src.LoBlock(0), out x0);
            vmovblock(src.HiBlock(0), out x1);
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
        /// VPMOVZXWD ymm, m128
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
        /// PMOVSXWD xmm, m64
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
        /// PMOVZXBQ xmm, m16
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vmovblock(ref byte src, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(ptr(ref src));
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
        /// PMOVZXWQ xmm, m32
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
        /// PMOVZXDQ xmm, m64
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
        /// VPMOVSXDQ ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vconvert(in ConstBlock128<int> src, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(constptr(in src.Head));
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
        /// VPMOVZXBW ymm, m128
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
        /// VPMOVZXBW ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock256<byte> src, out Vector256<ushort> lo, out Vector256<ushort> hi)
        {
            lo = v16u(ConvertToVector256Int16(constptr(in src.Head)));
            hi = v16u(ConvertToVector256Int16(constptr(in src.Head, 16)));
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
        /// VPMOVZXWQ ymm, m64
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
        /// VPMOVZXWQ ymm, m64
        /// </summary>
        /// <param name="src"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock256<ushort> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            lo = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            hi = v64u(ConvertToVector256Int64(constptr(in src.Head, 8)));
        }


        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vmovblock(in ConstBlock128<uint> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock128<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            lo = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            hi = v64u(ConvertToVector256Int64(constptr(in src.Head,4)));
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
        /// VPMOVZXBD ymm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vmovblock(in ConstBlock64<byte> src, out Vector256<uint> dst)
        {
            dst = v32u(ConvertToVector256Int32(constptr(in src.Head)));
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock256<uint> src, out Vector256<ulong> lo, out Vector256<ulong> hi)
        {
            lo = v64u(ConvertToVector256Int64(constptr(in src.LoBlock(0).Head)));
            hi = v64u(ConvertToVector256Int64(constptr(in src.HiBlock(0).Head)));   
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

        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock256<ushort> src, out Vector256<uint> lo, out Vector256<uint> hi)
        {
            lo = v32u(ConvertToVector256Int32(constptr(in src.LoBlock(0).Head)));
            hi = v32u(ConvertToVector256Int32(constptr(in src.HiBlock(0).Head)));
        }

        /// <summary>
        /// VPMOVSXWD ymm, m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="lo"></param>
        /// <param name="hi"></param>
        [MethodImpl(Inline)]
        public static unsafe void vmovblock(in ConstBlock256<ushort> src, out Vector256<int> lo, out Vector256<int> hi)
        {
            lo = ConvertToVector256Int32(constptr(in src.LoBlock(0).Head));
            hi = ConvertToVector256Int32(constptr(in src.HiBlock(0).Head));
        }

        /// <summary>
        /// VPMOVSXWQ ymm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vconvert(in ConstBlock64<ushort> src, out Vector256<long> dst)
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
        public static unsafe Vector256<int> vconvert(in ConstBlock128<short> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vconvert(in ConstBlock32<byte> src, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vconvert(ref ConstBlock64<byte> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(constptr(in src.Head));
            return dst;
        }



    }
}