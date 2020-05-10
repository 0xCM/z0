//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    [ApiHost]
    public readonly struct Pointed : IApiHost<Pointed>
    {
        [MethodImpl(Inline), Op]
        public static IntPtr intptr(long i)
            => new IntPtr(i);

        [MethodImpl(Inline), Op]
        public static unsafe IntPtr intptr(void* p)
            => new IntPtr(p);

        /// <summary>
        /// Presents generic reference as a generic pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe T* ptr<T>(ref T src)
            where T : unmanaged
                => (T*)pvoid(ref src);

        /// <summary>
        /// Presents a readonly reference as a generic pointer which should intself be considered constant
        /// but, as far as the author is aware, no facility within the language can encode that constraint
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* constptr<T>(in T src)
            where T : unmanaged
                => ptr(ref edit(in src));

        /// <summary>
        /// Presents a readonly reference as a generic pointer displaced by an element offset
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe T* constptr<T>(in T src, int offset)
            where T : unmanaged
                => ptr(ref edit(in skip(in src, offset)));

        /// <summary>
        /// Converts a generic reference into a void pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe void* pvoid<T>(ref T src)
            => Unsafe.AsPointer(ref src); 

        /// <summary>
        /// Presents generic reference as a generic pointer displaced by an element offset
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <param name="offset">The number of elements to skip</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe T* ptr<T>(ref T src, int offset)
            where T : unmanaged
                => (T*)Unsafe.AsPointer(ref seek(ref src, offset));

        /// <summary>
        /// Presents a generic reference r:T as a generic pointer p:T
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        /// <typeparam name="P">The target pointer type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe P* ptr<T,P>(ref T r)
            where T : unmanaged
            where P : unmanaged
                => (P*)Unsafe.AsPointer(ref r);

        /// <summary>
        /// Presents a generic reference as a byte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe byte* pbyte<T>(ref T r)
            where T : unmanaged
                => ptr<T,byte>(ref r);

        /// <summary>
        /// Presents a generic reference as an sbyte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe sbyte* psbyte<T>(ref T r)
            where T : unmanaged
                => ptr<T,sbyte>(ref r);

        /// <summary>
        /// Presents a generic reference as a byte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe byte* puint8<T>(ref T r)
            where T : unmanaged
                => ptr<T,byte>(ref r);

        /// <summary>
        /// Presents a generic reference as an sbyte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe sbyte* pint8<T>(ref T r)
            where T : unmanaged
                =>ptr<T,sbyte>(ref r);

        /// <summary>
        /// Presents a generic reference as a short pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe short* pint16<T>(ref T r)
            where T : unmanaged
                => ptr<T,short>(ref r);

        /// <summary>
        /// Presents a generic reference as a ushort pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ushort* puint16<T>(ref T r)
            where T : unmanaged
                => ptr<T,ushort>(ref r);

        /// <summary>
        /// Presents a generic reference as an int32 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe int* pint32<T>(ref T r)
            where T : unmanaged
                => ptr<T,int>(ref r);

        /// <summary>
        /// Presents a generic reference as an uint32 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe uint* puint32<T>(ref T r)
            where T : unmanaged
                => ptr<T,uint>(ref r);

        /// <summary>
        /// Presents a generic reference as an int64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe long* plong<T>(ref T r)
            where T : unmanaged
                => ptr<T,long>(ref r);

        /// <summary>
        /// Presents a generic reference as an int64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe long* pint64<T>(ref T r)
            where T : unmanaged
                => ptr<T,long>(ref r);

        /// <summary>
        /// Presents a generic reference as a uint64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ulong* pulong<T>(ref T r)
            where T : unmanaged
                => ptr<T,ulong>(ref r);

        /// <summary>
        /// Presents a generic reference as a uint64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ulong* puint64<T>(ref T r)
            where T : unmanaged
                => ptr<T,ulong>(ref r);
    }
}