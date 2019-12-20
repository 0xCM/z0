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

        // ~ 8i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVSXBQ xmm, m16
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vloadblock(in ConstBlock16<sbyte> src, N128 w, out Vector128<long> dst)
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
        public static unsafe Vector128<int> vloadblock(in ConstBlock32<sbyte> src, N128 w, out Vector128<int> dst)
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
        public static unsafe Vector256<long> vloadblock(in ConstBlock32<sbyte> src, N256 w, out Vector256<long> dst)
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
        public static unsafe Vector128<short> vloadblock(in ConstBlock64<sbyte> src, N128 w, out Vector128<short> dst)
        {
            dst = ConvertToVector128Int16(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        ///  VPMOVSXBD ymm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vloadblock(in ConstBlock64<sbyte> src, N256 w, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// VPMOVSXBW ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<short> vloadblock(in ConstBlock128<sbyte> src, N256 w, out Vector256<short> dst)
        {
            dst = ConvertToVector256Int16(constptr(in src.Head));
            return dst;
        }

        // ~ 8u -> X
        // ~ ------------------------------------------------------------------
        
        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vloadblock(in ConstBlock16<byte> src, N128 w, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vloadblock(in ConstBlock32<byte> src, N128 w, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2:8 -> 64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vloadblock(in ConstBlock16<byte> src, N128 w, out Vector128<ulong> dst)
        {
            dst = v64u(ConvertToVector128Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32u
        /// [0 1 2 3] -> [0 1 2 3]
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
        /// PMOVZXBQ xmm, m16
        /// 4x8u -> (2x64u, 2x64u)
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
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vloadblock(in ConstBlock32<byte> src, N256 w,  out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vloadblock(in ConstBlock32<byte> src, N256 w,  out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 4x8u -> (2x64u, 2x64u)
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe ConstPair<Vector128<ulong>> vloadblock(in ConstBlock32<byte> src, N128 w, ulong t = default)
            => Tuples.constant(
                    v64u(ConvertToVector128Int64(constptr(in src.Head))),
                    v64u(ConvertToVector128Int64(constptr(in src.Head,2))));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vloadblock(in ConstBlock64<byte> src, out Vector128<short> dst)
        {
            dst = ConvertToVector128Int16(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 8x8u -> (4x32u, 4x32u)
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        [MethodImpl(Inline)]
        public static unsafe ConstPair<Vector128<uint>> vloadblock(in ConstBlock64<byte> src, N128 w, uint t = default)
            => Tuples.constant(
                    v32u(ConvertToVector128Int32(constptr(in src.Head))),
                    v32u(ConvertToVector128Int32(constptr(in src.Head,4))));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vloadblock(in ConstBlock64<byte> src, N128 w,  ushort t = default)
            => v16u(ConvertToVector128Int16(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vloadblock(in ConstBlock64<byte> src, N256 w, uint t = default)
            => v32u(ConvertToVector256Int32(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vloadblock(in Block64<byte> src, N256 w, uint t = default)
            => v32u(ConvertToVector256Int32(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vloadblock(in Block64<byte> src, int index,  N256 w, uint t = default)
            => v32u(ConvertToVector256Int32(constptr(in src.BlockRef(index))));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]        
        public static unsafe Vector256<short> vloadblock(in ConstBlock128<byte> src, N256 w, short t = default)
            => ConvertToVector256Int16(constptr(in src.Head));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vloadblock(in ConstBlock128<byte> src, N256 w, ushort t = default)
            => v16u(ConvertToVector256Int16(constptr(in src.Head)));

        // ~ 16i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVSXWQ xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vloadblock(in ConstBlock32<short> src, N128 w, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(constptr(in src.Head));
            return dst;
        }

        // ~ 16u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vloadblock(in ConstBlock32<ushort> src, N128 w, out Vector128<long> dst)
        {
            dst = ConvertToVector128Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// 2x16 -> 2x64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vloadblock(in ConstBlock32<ushort> src, N128 w, ulong t = default)
            => v64u(ConvertToVector128Int64(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 4x16u -> 4x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vloadblock(in ConstBlock64<ushort> src, N256 w, out Vector256<ulong> dst)
        {
            dst = v64u(ConvertToVector256Int64(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16u -> 4x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vloadblock(in ConstBlock64<ushort> src, N128 w, out Vector128<uint> dst)
        {
            dst = v32u(ConvertToVector128Int32(constptr(in src.Head)));
            return dst;
        }

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 8x16u -> 8x32u
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
        /// VPMOVZXWD ymm, m128
        /// 16x16u ->(8x32u, 8x32u)
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        [MethodImpl(Inline)]
        public static unsafe ConstPair<Vector256<uint>> vloadblock(in ConstBlock256<ushort> src, N256 w, uint t = default)
            => Tuples.constant(
                v32u(ConvertToVector256Int32(constptr(in src.Head))),
                v32u(ConvertToVector256Int32(constptr(in src.Head, 8))));
        
        // ~ 32u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVZXDQ xmm, m64
        /// 2x32u -> 2x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vloadblock(in ConstBlock64<uint> src, N128 w, out Vector128<ulong> dst)
        {
           dst = v64u(ConvertToVector128Int64(constptr(in src.Head)));
           return dst;
        }

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 4x32u -> 4x64u
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
        /// PMOVZXBW xmm, m64
        /// 16x8u -> (8x16u, 8x16u)
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe ConstPair<Vector128<ushort>> vloadblock(in ConstBlock128<byte> src,  N128 w, ushort t = default)        
            => Tuples.constant(
                v16u(ConvertToVector128Int16(constptr(in src.Head))),
                v16u(ConvertToVector128Int16(constptr(in src.Head,8))));                    

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 32x8u -> (16x16u, 16x16u)
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline)]
        public static unsafe ConstPair<Vector256<ushort>> vloadblock(in ConstBlock256<byte> src, N256 w, ushort t = default)
            => Tuples.constant(
                v16u(ConvertToVector256Int16(constptr(in src.Head))),
                v16u(ConvertToVector256Int16(constptr(in src.Head,16))));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe ConstPair<Vector256<ulong>> vloadblock(in ConstBlock128<ushort> src, N256 w, ulong t = default)
            => Tuples.constant(
                v64u(ConvertToVector256Int64(constptr(in src.Head))),
                v64u(ConvertToVector256Int64(constptr(in src.Head,4))));
       
        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 8x32u -> (4x64u, 4x64u)
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline)]
        public static unsafe ConstPair<Vector256<ulong>> vloadblock(in ConstBlock256<uint> src, N256 w, ulong t = default)
            => Tuples.constant(
                v64u(ConvertToVector256Int64(constptr(in src.Head))),
                v64u(ConvertToVector256Int64(constptr(in src.Head,4))));

        /// <summary>
        /// PMOVZXDQ xmm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vloadblock(in ConstBlock64<uint> src, N128 w, ulong t = default)
            => ConvertToVector128Int64(constptr(in src.Head));

        // ~ 32i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVSXDQ xmm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vloadblock(in ConstBlock64<int> src, N128 w, long t = default)
            => ConvertToVector128Int64(constptr(in src.Head));

        /// <summary>
        /// VPMOVSXDQ ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vloadblock(in ConstBlock128<int> src, N256 w, out Vector256<long> dst)
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
        public static unsafe Vector256<long> vloadblock(in ConstBlock64<ushort> src, N256 w, out Vector256<long> dst)
        {
            dst = ConvertToVector256Int64(constptr(in src.Head));
            return dst;
        }

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vloadblock(in ConstBlock64<short> src, N128 w, int t = default)
            => ConvertToVector128Int32(constptr(in src.Head));
 
        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vloadblock(in ConstBlock128<uint> src, N256 w, long t = default)
            => ConvertToVector256Int64(constptr(in src.Head));

        /// <summary>
        /// VPMOVSXWD ymm, m128
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vloadblock(in ConstBlock128<short> src, N256 w, int t = default)
            => ConvertToVector256Int32(constptr(in src.Head));
    }
}