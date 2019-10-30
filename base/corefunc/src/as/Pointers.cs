//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Security;
    
    using static zfunc;

    public static partial class As
    {

        /// <summary>
        /// Converts a generic reference into a void pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void* pvoid<T>(ref T src)
            => Unsafe.AsPointer(ref src);
        
        /// <summary>
        /// Converts a generic reference into a generic pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T* refptr<T>(ref T src)
            where T : unmanaged
                => (T*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe T* constptr<T>(in T src)
            where T : unmanaged
                => refptr(ref asRef(in src));

        /// <summary>
        /// Increments a generic pointer by a specified amount
        /// </summary>
        /// <param name="pSrc">A reference to the pointer to increment</param>
        /// <param name="offset">The amount by which the pointer should be incremented</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline)]
        public static unsafe ref T* inc<T>(ref T* pSrc, int offset)
            where T : unmanaged
        {
            pSrc += offset;
            return ref pSrc;
        }

        [MethodImpl(Inline)]
        public static unsafe ref T* inc2<T>(ref T* pSrc, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ulong))
                pSrc = (T*)((ulong*)pSrc + offset);
            else if(typeof(T) == typeof(ushort))
                pSrc = (T*)((ushort*)pSrc + offset);
            else if(typeof(T) == typeof(uint))
                pSrc = (T*)((uint*)pSrc + offset);
            else
                pSrc = (T*)((byte*)pSrc + offset);                
            return ref pSrc;
        }

        [MethodImpl(Inline)]
        public static unsafe sbyte* refptr(ref sbyte src)
            => (sbyte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe byte* refptr(ref byte src)
            => (byte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe short* refptr(ref short src)
            => (short*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe ushort* refptr(ref ushort src)
            => (ushort*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe int* refptr(ref int src)
            => (int*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe uint* refptr(ref uint src)
            => (uint*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe long* refptr(ref long src)
            => (long*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe ulong* refptr(ref ulong src)
            => (ulong*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe float* refptr(ref float src)
            => (float*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe double* refptr(ref double src)
            => (double*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe sbyte* refptr(ref sbyte src, int offset)
            => (sbyte*)pvoid(ref advance(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe byte* refptr(ref byte src, int offset)
            => (byte*)pvoid(ref advance(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe short* refptr(ref short src, int offset)
            => (short*)pvoid(ref advance(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe ushort* refptr(ref ushort src, int offset)
            => (ushort*)pvoid(ref advance(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe int* refptr(ref int src, int offset)
            => (int*)pvoid(ref advance(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe uint* refptr(ref uint src, int offset)
            => (uint*)pvoid(ref advance(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe long* refptr(ref long src, int offset)
            => (long*)pvoid(ref advance(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe ulong* refptr(ref ulong src, int offset)
            => (ulong*)pvoid(ref advance(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe float* refptr(ref float src, int offset)
            => (float*)pvoid(ref advance(ref src, offset));

        [MethodImpl(Inline)]
        public static unsafe double* refptr(ref double src, int offset)
            => (double*)pvoid(ref advance(ref src, offset));


        [MethodImpl(Inline)]
        public static unsafe sbyte* pint8<T>(ref T src)
            => (sbyte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe byte* puint8<T>(ref T src)
            => (byte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe short* pint16<T>(ref T src)
            => (short*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe ushort* puint16<T>(ref T src)
            => (ushort*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe int* pint32<T>(ref T src)
            => (int*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe uint* puint32<T>(ref T src)
            => (uint*)pvoid(ref src);


        [MethodImpl(Inline)]
        public static unsafe long* pint64<T>(ref T src)
            => (long*)pvoid(ref src);


        [MethodImpl(Inline)]
        public static unsafe ulong* puint64<T>(ref T src)
            => (ulong*)pvoid(ref src);


        [MethodImpl(Inline)]
        public static unsafe float* pfloat32<T>(ref T src)
            => (float*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe double* pfloat64<T>(ref T src)
            => (double*)pvoid(ref src);


        [MethodImpl(Inline)]
        public static unsafe sbyte* constptr(in sbyte src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe byte* constptr(in byte src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe short* constptr(in short src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe ushort* constptr(in ushort src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe int* constptr(in int src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe uint* constptr(in uint src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe long* constptr(in long src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe ulong* constptr(in ulong src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe float* constptr(in float src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe double* constptr(in double src)
            => refptr(ref asRef(in src));


        [MethodImpl(Inline)]
        public static unsafe sbyte* constptr(in sbyte src, int offset)
            => refptr(ref advance(ref asRef(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe byte* constptr(in byte src, int offset)
            => refptr(ref advance(ref asRef(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe short* constptr(in short src, int offset)
            => refptr(ref advance(ref asRef(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe ushort* constptr(in ushort src, int offset)
            => refptr(ref advance(ref asRef(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe int* constptr(in int src, int offset)
            => refptr(ref advance(ref asRef(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe uint* constptr(in uint src, int offset)
            => refptr(ref advance(ref asRef(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe long* constptr(in long src, int offset)
            => refptr(ref advance(ref asRef(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe ulong* constptr(in ulong src, int offset)
            => refptr(ref advance(ref asRef(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe float* constptr(in float src, int offset)
            => refptr(ref advance(ref asRef(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe double* constptr(in double src, int offset)
            => refptr(ref advance(ref asRef(in src), offset));

        [MethodImpl(Inline)]
        public static unsafe P* refptr<P,T>(ref T src)
            where T : unmanaged
            where P : unmanaged
                => (P*)Unsafe.AsPointer(ref src);

        [MethodImpl(Inline)]
        public static IntPtr intptr(long i)
            => new IntPtr(i);

        [MethodImpl(Inline)]
        public static IntPtr intptr(int i)
            => new IntPtr(i);

        /// <summary>
        /// Adds an offset to a reference, measured relative to the reference type
        /// </summary>
        /// <param name="src">The soruce reference</param>
        /// <param name="bytes">The number of elements to add</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T advance<T>(ref T src, int elements)
            where T : unmanaged
                => ref Unsafe.Add(ref src, elements);

        /// <summary>
        /// Adds an offset to a reference, measured in bytes
        /// </summary>
        /// <param name="src">The soruce reference</param>
        /// <param name="bytes">The number of bytes to add</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T advanceb<T>(ref T src, long bytes)
            where T : unmanaged
                => ref Unsafe.AddByteOffset(ref src, intptr(bytes));

    }

}