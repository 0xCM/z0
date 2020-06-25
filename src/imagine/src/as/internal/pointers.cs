//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    using static As;

    partial struct AsInternal
    {
        /// <summary>
        /// Converts a generic reference into a void pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe void* pvoid<T>(ref T src)
            => AsPointer(ref src); 

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

        /// <summary>
        /// Presents generic reference as a generic pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        internal static unsafe T* ptr<T>(ref T src)
            where T : unmanaged
                => (T*)pvoid(ref src);

        /// <summary>
        /// Presents a generic reference r:T as a generic pointer p:T
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        /// <typeparam name="P">The target pointer type</typeparam>
        [MethodImpl(Inline)]
        internal static unsafe P* ptr<T,P>(ref T r)
            where T : unmanaged
            where P : unmanaged
                => (P*)Unsafe.AsPointer(ref r);
    }
}