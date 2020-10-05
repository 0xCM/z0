//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;

    public readonly struct EnumValue
    {
        /// <summary>
        /// Reads an E-value from an enum of primal T-kind
        /// </summary>
        /// <param name="tVal">The integral value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E,T>(in T tVal, E eRep = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => ref z.@as<T,E>(tVal);

        /// <summary>
        /// Reads a T-value from the value of an E-enum of primal T-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T scalar<E,T>(in E eVal, T tRep = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => ref z.@as<E,T>(eVal);

        /// <summary>
        /// Envisions an E-enum value of primal i8-kind as a like-kinded scalar value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal i8-kind</typeparam>
        [MethodImpl(Inline)]
        public static ref sbyte e8i<E>(ref E eVal)
            where E : unmanaged, Enum
                => ref scalar<E,sbyte>(eVal);

        /// <summary>
        /// Envisions an E-enum value of primal u8-kind as a like-kinded scalar value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal u8-kind</typeparam>
        [MethodImpl(Inline)]
        public static byte e8u<E>(E eVal)
            where E : unmanaged, Enum
                => scalar<E,byte>(eVal);

        /// <summary>
        /// Envisions an E-enum value of primal i16-kind as a like-kinded scalar value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal i16-kind</typeparam>
        [MethodImpl(Inline)]
        public static short e16i<E>(E eVal)
            where E : unmanaged, Enum
                => scalar<E,short>(eVal);

        /// <summary>
        /// Envisions an E-enum value of primal u16-kind as a like-kinded scalar value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal u16-kind</typeparam>
        [MethodImpl(Inline)]
        public static ushort e16u<E>(E eVal)
            where E : unmanaged, Enum
                => scalar<E,ushort>(eVal);

        /// <summary>
        /// Envisions an E-enum value of primal u16-kind as a c16 value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal u16-kind</typeparam>
        [MethodImpl(Inline)]
        public static char e16c<E>(E eVal)
            where E : unmanaged, Enum
                => (char)scalar<E,ushort>(eVal);

        [MethodImpl(Inline)]
        public static int e32i<E>(E eVal)
            where E : unmanaged, Enum
                => scalar<E,int>(eVal);

        [MethodImpl(Inline)]
        public static uint e32u<E>(E eVal)
            where E : unmanaged, Enum
                => scalar<E,uint>(eVal);

        [MethodImpl(Inline)]
        public static long e64i<E>(E eVal)
            where E : unmanaged, Enum
                => scalar<E,long>(eVal);

        [MethodImpl(Inline)]
        public static ulong e64u<E>(E eVal)
            where E : unmanaged, Enum
                => scalar<E,ulong>(eVal);

        /// <summary>
        /// Envisions a u8 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u8-kind</typeparam>
        [MethodImpl(Inline)]
        public static E eVal<E>(byte tVal, E eRep = default)
            where E : unmanaged, Enum
                => literal<E,byte>(tVal);

        /// <summary>
        /// Envisions an i8 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i8-kind</typeparam>
        [MethodImpl(Inline)]
        public static E eVal<E>(sbyte src, E rep = default)
            where E : unmanaged, Enum
                => literal<E,sbyte>(src);

        /// <summary>
        /// Envisions an i16 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i16-kind</typeparam>
        [MethodImpl(Inline)]
        public static E eVal<E>(short src, E rep = default)
            where E : unmanaged, Enum
                => literal<E,short>(src);

        /// <summary>
        /// Envisions a u16 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u16-kind</typeparam>
        [MethodImpl(Inline)]
        public static E eVal<E>(ushort src, E rep = default)
            where E : unmanaged, Enum
                => literal<E,ushort>(src);

        [MethodImpl(Inline)]
        public static ref T store<E,T>(in E e, out T dst)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            dst = z.@as<E,T>(e);
            return ref dst;
        }
    }
}