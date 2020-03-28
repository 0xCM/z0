//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;    
    using static System.Runtime.Intrinsics.X86.Avx2;    
     
    using static vgeneric;
    using static refs;

    partial class dvec
    {                
        // ~ 8i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVSXBQ xmm, m16
        /// 2x8i -> 2x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert(in Block16<sbyte> src, N128 w, long t = default)
            => ConvertToVector128Int64(constptr(in src.Head));

        /// <summary>
        /// PMOVSXBD xmm, m32
        /// 4x8i -> 4x32i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vconvert(in Block32<sbyte> src, N128 w, int t  = default)
            => ConvertToVector128Int32(constptr(in src.Head));

        /// <summary>
        ///  VPMOVSXBQ ymm, m32
        /// 4x8i -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vconvert(in Block32<sbyte> src, N256 w, long t = default)
            => ConvertToVector256Int64(constptr(in src.Head));

        /// <summary>
        /// PMOVSXBW xmm, m64
        /// 8x8i -> 8x16i
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vconvert(in Block64<sbyte> src, N128 w, short t = default)
            => ConvertToVector128Int16(constptr(in src.Head));

        /// <summary>
        ///  VPMOVSXBD ymm, m64
        /// 8x8i -> 8x32i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<int> vconvert(in Block64<sbyte> src, N256 w, int t = default)
            => ConvertToVector256Int32(constptr(in src.Head));

        /// <summary>
        /// VPMOVSXBW ymm, m128
        /// 16x8i -> 16x16i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<short> vconvert(in Block128<sbyte> src, N256 w, short t = default)
            => ConvertToVector256Int16(constptr(in src.Head));

        // ~ 8u -> X
        // ~ ------------------------------------------------------------------
        
        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert(in Block16<byte> src, N128 w, long t = default)
            => ConvertToVector128Int64(constptr(in src.Head));

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="block">The block index</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert(in Block16<byte> src, int block, N128 w, long t = default)
            => ConvertToVector128Int64(constptr(in src.BlockRef(block)));

        /// <summary>
        /// PMOVZXBQ xmm, m16
        /// 2x8u -> 2x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vconvert(in Block16<byte> src, N128 w, ulong t = default)
            => v64u(ConvertToVector128Int64(constptr(in src.Head)));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vconvert(in Block32<byte> src, N128 w, int t = default)
            => ConvertToVector128Int32(constptr(in src.Head));

        /// <summary>
        /// PMOVZXBD xmm, m32
        /// 4x8u -> 4x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vconvert(in Block32<byte> src, N128 w, uint t = default)
            => v32u(ConvertToVector128Int32(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vconvert(in Block32<byte> src, N256 w, ulong t = default)
            => v64u(ConvertToVector256Int64(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXBQ ymm, m32
        /// 4x8u -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vconvert(in Block32<byte> src, N256 w, long t = default)
            => ConvertToVector256Int64(constptr(in src.Head));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<short> vconvert(in Block64<byte> src, N128 w, short t = default)
            => ConvertToVector128Int16(constptr(in src.Head));

        /// <summary>
        /// PMOVZXBW xmm, m64
        /// 8x8u -> 8x16u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ushort> vconvert(in Block64<byte> src, N128 w, ushort t = default)
            => v16u(ConvertToVector128Int16(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXBD ymm, m64
        /// 8x8u -> 8x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert(in Block64<byte> src, N256 w, uint t = default)
            => v32u(ConvertToVector256Int32(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<short> vconvert(in Block128<byte> src, N256 w, short t = default)
            => ConvertToVector256Int16(constptr(in src.Head));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ushort> vconvert(in Block128<byte> src, N256 w, ushort t = default)
            => v16u(ConvertToVector256Int16(constptr(in src.Head)));

        // ~ 16i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVSXWQ xmm, m32
        /// 2x16i -> 2x64u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert(in Block32<short> src, N128 w, long t = default)
            => ConvertToVector128Int64(constptr(in src.Head));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16i -> 4x32i
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<int> vconvert(in Block64<short> src, N128 w, int t = default)
            => ConvertToVector128Int32(constptr(in src.Head));

        // ~ 16u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert(in Block32<ushort> src, N128 w, long t = default)
            => ConvertToVector128Int64(constptr(in src.Head));

        /// <summary>
        /// PMOVZXWQ xmm, m32
        /// 2x16u -> 2x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<ulong> vconvert(in Block32<ushort> src, N128 w, ulong t = default)
            => v64u(ConvertToVector128Int64(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 4x16u -> 4x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vconvert(in Block64<ushort> src, N256 w, ulong t = default)
            => v64u(ConvertToVector256Int64(constptr(in src.Head)));

        /// <summary>
        /// PMOVSXWD xmm, m64
        /// 4x16u -> 4x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<uint> vconvert(in Block64<ushort> src, N128 w, uint t = default)
            => v32u(ConvertToVector128Int32(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 8x16u -> 8x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<uint> vconvert(in Block128<ushort> src, uint t = default)
            => v32u(ConvertToVector256Int32(constptr(in src.Head)));

        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 8x16u -> 8x32i
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<int> vconvert(in Block128<ushort> src, int t = default)
            => ConvertToVector256Int32(constptr(in src.Head));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 4x16u -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vconvert(in Block64<ushort> src, N256 w, long t = default)
            => ConvertToVector256Int64(constptr(in src.Head));

        // ~ 32u -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 4x32u -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vconvert(in Block128<uint> src, N256 w, long t = default)
            => ConvertToVector256Int64(constptr(in src.Head));

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 4x32u -> 4x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<ulong> vconvert(in Block128<uint> src, ulong t = default)
            => v64u(ConvertToVector256Int64(constptr(in src.Head)));

        /// <summary>
        /// PMOVZXDQ xmm, m64
        /// 2x32u -> 2x64u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert(in Block64<uint> src, N128 w, ulong t = default)
            => ConvertToVector128Int64(constptr(in src.Head));

        // ~ 32i -> X
        // ~ ------------------------------------------------------------------

        /// <summary>
        /// PMOVSXDQ xmm, m64
        /// 2x32i -> 2x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<long> vconvert(in Block64<int> src, N128 w, long t = default)
            => ConvertToVector128Int64(constptr(in src.Head));

        /// <summary>
        /// VPMOVSXDQ ymm, m128
        /// 4x32i -> 4x64i
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector256<long> vconvert(in Block128<int> src, N256 w, long t = default)
            => ConvertToVector256Int64(constptr(in src.Head));

        // ~ X -> 512
        // ~ ------------------------------------------------------------------
        
        /// <summary>
        /// VPMOVZXWD ymm, m128
        /// 16x16u ->16x32u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<uint> vconvert(in Block256<ushort> src, N512 w, uint t = default)
            => (v32u(ConvertToVector256Int32(constptr(in src.Head))),
                v32u(ConvertToVector256Int32(constptr(in src.Head, 8))));

        /// <summary>
        /// VPMOVSXWD ymm, m128
        /// 16x16u ->16x32u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<int> vconvert(in Block128<short> src, N512 w, int t = default)
            => (ConvertToVector256Int32(constptr(in src.Head)),
                ConvertToVector256Int32(constptr(in src.Head, 8)));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 32x8u -> 32x16u
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="lo">The lo target</param>
        /// <param name="hi">The hi target</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ushort> vconvert(in Block256<byte> src, N512 w, ushort t = default)
            => (v16u(ConvertToVector256Int16(constptr(in src.Head))),
                v16u(ConvertToVector256Int16(constptr(in src.Head,16))));

        /// <summary>
        /// VPMOVZXWQ ymm, m64
        /// 8x16u -> 8x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ulong> vconvert(in Block128<ushort> src, N512 w, ulong t = default)
            => (v64u(ConvertToVector256Int64(constptr(in src.Head))),
                v64u(ConvertToVector256Int64(constptr(in src.Head,4))));

        /// <summary>
        /// VPMOVZXDQ ymm, m128
        /// 8x32u -> 8x64u
        /// </summary>
        /// <param name="src">The blocked memory source</param>
        /// <param name="lo">The lower taret</param>
        /// <param name="hi">The upper taret</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector512<ulong> vconvert(in Block256<uint> src, N512 w, ulong t = default)
            => (v64u(ConvertToVector256Int64(constptr(in src.Head))),
                v64u(ConvertToVector256Int64(constptr(in src.Head,4)))); 
    }
}