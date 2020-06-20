//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {                
        /// <summary>
        /// Reads a T-value from the value of an E-enum of primal T-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T tVal<E,T>(E eVal)
            where E : unmanaged, Enum
            where T : unmanaged
                => EnumValue.tVal<E,T>(eVal);

        /// <summary>
        /// Reads a u8 value from the value of an E-enum of primal u8-kind
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static byte e8u<E>(E eVal) 
            where E : unmanaged, Enum
                => EnumValue.e8u(eVal);

        [MethodImpl(Inline)]
        public static sbyte e8i<E>(E eVal) 
            where E : unmanaged, Enum
                => EnumValue.e8i(eVal);

        [MethodImpl(Inline)]
        public static short e16i<E>(E eVal) 
            where E : unmanaged, Enum
                => EnumValue.e16i(eVal);

        [MethodImpl(Inline)]
        public static ushort e16u<E>(E eVal) 
            where E : unmanaged, Enum
                => EnumValue.e16u(eVal);

        [MethodImpl(Inline)]
        public static char e16c<E>(E eVal) 
            where E : unmanaged, Enum
                => EnumValue.e16c(eVal);

        [MethodImpl(Inline)]
        public static int e32i<E>(E eVal) 
            where E : unmanaged, Enum
                => EnumValue.e32i(eVal);

        [MethodImpl(Inline)]
        public static uint e32u<E>(E eVal) 
            where E : unmanaged, Enum
                => EnumValue.e32u(eVal);

        [MethodImpl(Inline)]
        public static long e64i<E>(E eVal) 
            where E : unmanaged, Enum
                => EnumValue.e64i(eVal);

        [MethodImpl(Inline)]
        public static ulong e64u<E>(E eVal) 
            where E : unmanaged, Enum
                => EnumValue.e64u(eVal);
    }
}