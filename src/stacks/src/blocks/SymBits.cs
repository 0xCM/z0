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
 
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;
    using static Control;
    using static Typed;

    public class SymBits
    {        
        [MethodImpl(Inline)]
        public static ref Vector256<ushort> v16u<T>(in Vector256<T> src)
            where T : unmanaged        
                => ref Unsafe.As<Vector256<T>,Vector256<ushort>>(ref edit(in src));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static sbyte extract(sbyte src, byte k0, byte k1)        
            => (sbyte)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static byte extract(byte src, byte k0, byte k1)        
            => (byte)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static short extract(short src, byte k0, byte k1)        
            => (short)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ushort extract(ushort src, byte k0, byte k1)        
            => (ushort)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static uint extract(uint src, byte k0, byte k1)        
            => Bmi1.BitFieldExtract(src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static int extract(int src, byte k0, byte k1)        
            => (int)Bmi1.BitFieldExtract((uint)src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static ulong extract(ulong src, byte k0, byte k1)
            => Bmi1.X64.BitFieldExtract(src, k0, (byte)(k1 - k0 + 1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static long extract(long src, byte k0, byte k1)
            => (long)Bmi1.X64.BitFieldExtract((ulong)src, k0, (byte)(k1 - k0 + 1));            

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static float extract(float src, byte k0, byte k1)
            => BitConverter.Int32BitsToSingle(extract(BitConverter.SingleToInt32Bits(src), k0, k1));

        /// <summary>
        /// Extracts a contiguous range of bits from the source inclusively between two index positions
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="k0">The bit position within the source where extraction should begin</param>
        /// <param name="k1">The bit position within the source where extraction should end</param>
        [MethodImpl(Inline)]
        public static double extract(double src, byte k0, byte k1)
            => BitConverter.Int64BitsToDouble(extract(BitConverter.DoubleToInt64Bits(src), k0, k1));

        [MethodImpl(Inline)]
        public static ref readonly ushort read(in char src)        
            => ref Unsafe.As<char,ushort>(ref edit(src));

        [MethodImpl(Inline)]
        public static ref readonly ushort read(in char src, int offset)        
            => ref read(Unsafe.Add(ref edit(src), offset));

        [MethodImpl(Inline)]
        public static ref ushort write(ref char src)
            => ref Unsafe.As<char,ushort>(ref src);

        [MethodImpl(Inline)]
        public static ref ushort write(ref char src, int offset)        
            => ref write(ref Unsafe.Add(ref edit(src), offset));

        /// <summary>
        /// VPMOVZXBW ymm, m128
        /// 16x8u -> 16x16u
        /// Projects 16 unsigned 8-bit integers onto 16 unsigned 16-bit integers
        /// </summary>
        /// <param name="src">The input component source</param>
        /// <param name="n">The source component count</param>
        /// <param name="w">The target component width</param>
        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vmove8x16(in byte src)
            => ConvertToVector256Int16(constptr(src)).AsUInt16();

        [MethodImpl(Inline)]
        public static Vector256<ushort> vinflate(Vector128<byte> src)
            => ConvertToVector256Int16(src).AsUInt16();

        [MethodImpl(Inline)]
        public static Vector256<ushort> vinflate(Vector256<byte> src, N0 lo)
            => vinflate(vlo(src));

        [MethodImpl(Inline)]
        public static Vector256<ushort> vinflate(Vector256<byte> src, N1 hi)
            => vinflate(vhi(src));

        [MethodImpl(Inline)]
        public static ushort vextract(Vector128<ushort> src, byte index)   
        {
            var x = ShiftRightLogical(src, index);
            return (ushort)ConvertToUInt32(x.AsUInt32());
        }

        [MethodImpl(Inline)]
        public static ushort vextract(Vector256<ushort> src, byte index)   
        {
            var x = ShiftRightLogical(src, index);
            return (ushort)ConvertToUInt32(x.AsUInt32());
        }

        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> vbroadcast(W128 w, byte src)
            => BroadcastScalarToVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vbroadcast(W128 w, ushort src)
            => BroadcastScalarToVector128(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vbroadcast(W256 w, byte src)
            => BroadcastScalarToVector256(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vbroadcast(W256 w, ushort src)
            => BroadcastScalarToVector256(&src);

        [MethodImpl(Inline)]
        public static unsafe Vector512<byte> vbroadcast(W512 w, byte src)
            => (BroadcastScalarToVector256(&src),BroadcastScalarToVector256(&src));

        [MethodImpl(Inline)]
        public static unsafe Vector512<ushort> vbroadcast(W512 w, ushort src)
            => (BroadcastScalarToVector256(&src),BroadcastScalarToVector256(&src));

        [MethodImpl(Inline)]
        public static Vector128<byte> vbytes(W128 w, ulong lo)
            => Vector128.CreateScalarUnsafe(lo).As<ulong,byte>();

        [MethodImpl(Inline)]
        public static Vector128<byte> vbytes(W128 w, ulong lo, ulong hi)
            => Vector128.Create(lo,hi).As<ulong,byte>();

        [MethodImpl(Inline)]
        public static Vector256<byte> vbytes(W256 w, ulong x0, ulong x1, ulong x2, ulong x3)
            => Vector256.Create(x0,x1,x2,x3).As<ulong,byte>();

        [MethodImpl(Inline)]
        public static unsafe Vector128<sbyte> vload(W128 w, in sbyte src)
            => LoadDquVector128((sbyte*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector128<byte> vload(W128 w, in byte src)
            => LoadDquVector128((byte*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector128<short> vload(W128 w, in short src)
            => LoadDquVector128((short*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector128<ushort> vload(W128 w, in ushort src)
            => LoadDquVector128((ushort*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector128<int> vload(W128 w, in int src)
            => LoadDquVector128((int*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector128<uint> vload(W128 w, in uint src)
            => LoadDquVector128((uint*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector128<long> vload(W128 w, in long src)
            => LoadDquVector128((long*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector128<ulong> vload(W128 w, in ulong src)
            => LoadDquVector128((ulong*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector256<sbyte> vload(W256 w, in sbyte src)
            => LoadDquVector256((sbyte*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector256<byte> vload(W256 w, in byte src)
            => LoadDquVector256((byte*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector256<short> vload(W256 w, in short src)
            => LoadDquVector256((short*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector256<ushort> vload(W256 w, in ushort src)
            => LoadDquVector256((ushort*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector256<int> vload(W256 w, in int src)
            => LoadDquVector256((int*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector256<uint> vload(W256 w, in uint src)
            => LoadDquVector256((uint*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector256<long> vload(W256 w, in long src)
            => LoadDquVector256((long*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector256<ulong> vload(W256 w, in ulong src)
            => LoadDquVector256((ulong*)src);            

        [MethodImpl(Inline)]
        public static unsafe Vector512<byte> vload(W512 w, in byte src)
            => (vload(n256, in src), vload(n256, Unsafe.Add(ref edit(src), 32)));

        [MethodImpl(Inline)]
        public static unsafe Vector512<ushort> vload(W512 w, in ushort src)
            => (vload(n256, in src), vload(n256, Unsafe.Add(ref edit(src), 16)));

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector128<byte> src, ref byte dst)
            => Store(ptr(ref dst), src);            

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector256<byte> src, ref byte dst)
            => Store(ptr(ref dst), src);            

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector512<byte> src, ref byte dst)
        {
            vstore(src.Lo, ref dst);
            vstore(src.Hi, ref Unsafe.Add(ref dst, 32));   
        }

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector128<byte> src, Span<byte> dst)
            => vstore(src, ref head(dst));

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector256<byte> src, Span<byte> dst)
            => vstore(src, ref head(dst));

        [MethodImpl(Inline), Op]
        public static unsafe void vstore(Vector512<byte> src, Span<byte> dst)
            => vstore(src, ref head(dst));

        [MethodImpl(Inline)]
        public static byte vextract(Vector128<byte> src, byte index)
            => Extract(src,index);

        [MethodImpl(Inline)]
        public static byte vextract(Vector128<byte> src, N0 index)
            => Extract(src, 0);

        [MethodImpl(Inline)]
        public static byte vextract(Vector128<byte> src, N1 index)
            => Extract(src, 1);

        [MethodImpl(Inline)]
        public static byte vextract(Vector128<byte> src, N2 index)
            => Extract(src, 2);

        [MethodImpl(Inline)]
        public static byte vextract(Vector128<byte> src, N3 index)
            => Extract(src, 3);

        [MethodImpl(Inline)]
        public static byte vextract(Vector128<byte> src, N4 index)
            => Extract(src, 4);

        [MethodImpl(Inline)]
        public static ulong vlo(Vector128<byte> src)
            => src.AsUInt64().GetElement(0);

        [MethodImpl(Inline)]
        public static ulong vlo(Vector128<ushort> src)
            => src.AsUInt64().GetElement(0);

        [MethodImpl(Inline)]
        public static ulong vhi(Vector128<byte> src)
            => src.AsUInt64().GetElement(1);

        [MethodImpl(Inline)]
        public static ulong vhi(Vector128<ushort> src)
            => src.AsUInt64().GetElement(1);

        [MethodImpl(Inline)]
        public static Vector128<byte> vlo(Vector256<byte> src)
            => Vector256.GetLower(src);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vlo(Vector256<ushort> src)
            => Vector256.GetLower(src);

        [MethodImpl(Inline)]
        public static Vector128<byte> vhi(Vector256<byte> src)
            => Vector256.GetUpper(src);

        [MethodImpl(Inline)]
        public static Vector128<ushort> vhi(Vector256<ushort> src)
            => Vector256.GetUpper(src);

        [MethodImpl(Inline)]
        public static Vector256<byte> vlo(Vector512<byte> src)
            => src.Lo;

        [MethodImpl(Inline)]
        public static Vector256<byte> vhi(Vector512<byte> src)
            => src.Hi;
    }
}