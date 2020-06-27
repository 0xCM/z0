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
        /// Presents a generic reference as a byte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe byte* point8u<T>(ref T r)
            where T : unmanaged
                => refptr<T,byte>(ref r);

        /// <summary>
        /// Presents a generic reference as an sbyte pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe sbyte* point8i<T>(ref T r)
            where T : unmanaged
                => refptr<T,sbyte>(ref r);
        

        /// <summary>
        /// Presents a generic reference as a short pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe short* point16i<T>(ref T r)
            where T : unmanaged
                => refptr<T,short>(ref r);

        /// <summary>
        /// Presents a generic reference as a ushort pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ushort* point16u<T>(ref T r)
            where T : unmanaged
                => refptr<T,ushort>(ref r);

        /// <summary>
        /// Presents a generic reference as an int32 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe int* point32i<T>(ref T r)
            where T : unmanaged
                => refptr<T,int>(ref r);

        /// <summary>
        /// Presents a generic reference as an uint32 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe uint* point32u<T>(ref T r)
            where T : unmanaged
                => refptr<T,uint>(ref r);

        /// <summary>
        /// Presents a generic reference as an int64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe long* point64i<T>(ref T r)
            where T : unmanaged
                => refptr<T,long>(ref r);

        /// <summary>
        /// Presents a generic reference as an int64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe long* point64u<T>(ref T r)
            where T : unmanaged
                => refptr<T,long>(ref r);

        /// <summary>
        /// Presents a generic reference as a uint64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ulong* pulong<T>(ref T r)
            where T : unmanaged
                => refptr<T,ulong>(ref r);

        /// <summary>
        /// Presents a generic reference as a uint64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ulong* puint64<T>(ref T r)
            where T : unmanaged
                => refptr<T,ulong>(ref r);                

    }
}