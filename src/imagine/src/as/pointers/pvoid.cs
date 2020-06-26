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

    partial struct As
    {
        /// <summary>
        /// Converts a generic reference into a void pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The type of the referenced data</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe void* pvoid<T>(in T src)
            => AsPointer(ref edit(src)); 

        /// <summary>
        /// Presents a generic reference as a byte pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe byte* p8u<T>(in T src)
            where T : unmanaged
                => pref<T,byte>(ref edit(src));

        /// <summary>
        /// Presents a generic reference as an sbyte pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe sbyte* p8i<T>(in T src)
            where T : unmanaged
                => pref<T,sbyte>(ref edit(src));
        
        /// <summary>
        /// Presents a generic reference as a short pointer
        /// </summary>
        /// <param name="src">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe short* p16i<T>(in T src)
            where T : unmanaged
                => pref<T,short>(ref edit(src));

        /// <summary>
        /// Presents a generic reference as a ushort pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe ushort* p16u<T>(in T r)
            where T : unmanaged
                => pref<T,ushort>(ref edit(r));

        /// <summary>
        /// Presents a generic reference as an int32 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe int* p32i<T>(in T r)
            where T : unmanaged
                => pref<T,int>(ref edit(r));

        /// <summary>
        /// Presents a generic reference as an uint32 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe uint* p32u<T>(in T r)
            where T : unmanaged
                => pref<T,uint>(ref edit(r));

        /// <summary>
        /// Presents a generic reference as an int64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe long* p64i<T>(in T r)
            where T : unmanaged
                => pref<T,long>(ref edit(r));

        /// <summary>
        /// Presents a generic reference as an int64 pointer
        /// </summary>
        /// <param name="r">The memory reference</param>
        /// <typeparam name="T">The source reference type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe long* p64u<T>(in T r)
            where T : unmanaged
                => pref<T,long>(ref edit(r));

    }
}