//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Control
    {                
        /// <summary>
        /// Reads a generic numeric value from a generic enum. 
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T scalar<E,T>(E e)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<T>((T*)(&e));

        /// <summary>
        /// Presents an enum value as a U8 value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static byte e8u<E>(E src) 
            where E : unmanaged, Enum
                => scalar<E,byte>(src);

        /// <summary>
        /// Presents an enum value as a I8 value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static sbyte e8i<E>(E src) 
            where E : unmanaged, Enum
                => scalar<E,sbyte>(src);

        /// <summary>
        /// Presents an enum value as a I16 value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static short e16i<E>(E src) 
            where E : unmanaged, Enum
                => scalar<E,short>(src);

        /// <summary>
        /// Presents an enum value as a U16 value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ushort e16u<E>(E src) 
            where E : unmanaged, Enum
                => scalar<E,ushort>(src);

        /// <summary>
        /// Presents an enum value as a C16 value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static char e16c<E>(E src) 
            where E : unmanaged, Enum
                => (char)scalar<E,ushort>(src);

        /// <summary>
        /// Presents an enum value as a I32 value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static int e32i<E>(E src) 
            where E : unmanaged, Enum
                => scalar<E,int>(src);

        /// <summary>
        /// Presents an enum value as a U32 value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static uint e32u<E>(E src) 
            where E : unmanaged, Enum
                => scalar<E,uint>(src);

        /// <summary>
        /// Presents an enum value as a I64 value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static long e64i<E>(E src) 
            where E : unmanaged, Enum
                => scalar<E,long>(src);

        /// <summary>
        /// Presents an enum value as a U64 value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ulong e64u<E>(E src) 
            where E : unmanaged, Enum
                => scalar<E,ulong>(src);
    }
}