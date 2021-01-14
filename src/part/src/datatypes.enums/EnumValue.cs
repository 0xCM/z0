//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct EnumValue
    {
        const NumericKind Closure = Integers;

        [MethodImpl(Inline)]
        public static E zero<E>()
            where E : unmanaged, Enum
                => default(E);

        [MethodImpl(Inline)]
        public static ref T store<E,T>(in E e, out T dst)
            where E : unmanaged
            where T : unmanaged
        {
            dst = @as<E,T>(e);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe E read<E,T>(in T scalar, E e = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<E>(gptr<T,E>(scalar));

        /// <summary>
        /// Reads an E-value from an enum of primal T-kind
        /// </summary>
        /// <param name="scalar">The integral value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E,T>(in T scalar, E eRep = default)
            where E : unmanaged
            where T : unmanaged
                => ref @as<T,E>(scalar);

        /// <summary>
        /// Reads a T-value from the value of an E-enum of primal T-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T scalar<E,T>(in E eVal, T tRep = default)
            where E : unmanaged
            where T : unmanaged
                => ref @as<E,T>(eVal);

        /// <summary>
        /// Envisions an E-enum value of primal i8-kind as a like-kinded scalar value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal i8-kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref sbyte e8i<E>(in E eVal)
            where E : unmanaged
                => ref scalar<E,sbyte>(eVal);

        /// <summary>
        /// Envisions an E-enum value of primal u8-kind as a like-kinded scalar value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal u8-kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte e8u<E>(in E eVal)
            where E : unmanaged
                => ref scalar<E,byte>(eVal);

        /// <summary>
        /// Envisions an E-enum value of primal i16-kind as a like-kinded scalar value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal i16-kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref short e16i<E>(in E eVal)
            where E : unmanaged
                => ref scalar<E,short>(eVal);

        /// <summary>
        /// Envisions an E-enum value of primal u16-kind as a like-kinded scalar value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal u16-kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort e16u<E>(in E eVal)
            where E : unmanaged
                => ref scalar<E,ushort>(eVal);

        /// <summary>
        /// Envisions an E-enum value of primal u16-kind as a c16 value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal u16-kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref char e16c<E>(in E eVal)
            where E : unmanaged
                => ref scalar<E,char>(eVal);

        /// <summary>
        /// Interprets an enum value as a signed 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref int e32i<E>(in E eVal)
            where E : unmanaged
                => ref scalar<E,int>(eVal);

        /// <summary>
        /// Interprets an enum value as an unsigned 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint e32u<E>(in E eVal)
            where E : unmanaged
                => ref scalar<E,uint>(eVal);

        /// <summary>
        /// Interprets an enum value as a signed 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref long e64i<E>(in E eVal)
            where E : unmanaged
                => ref scalar<E,long>(eVal);

        /// <summary>
        /// Interprets an enum value as an unsigned 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong e64u<E>(in E eVal)
            where E : unmanaged
                => ref scalar<E,ulong>(eVal);

        /// <summary>
        /// Envisions a u8 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u8-kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref E eVal<E>(in byte tVal)
            where E : unmanaged
                => ref literal<E,byte>(tVal);

        /// <summary>
        /// Envisions an i8 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i8-kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref E eVal<E>(in sbyte src)
            where E : unmanaged
                => ref literal<E,sbyte>(src);

        /// <summary>
        /// Envisions an i16 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i16-kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref E eVal<E>(in short src)
            where E : unmanaged
                => ref literal<E,short>(src);

        /// <summary>
        /// Envisions a u16 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u16-kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref E eVal<E>(in ushort src)
            where E : unmanaged
                => ref literal<E,ushort>(src);


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static byte force8u<E>(E src)
            where E : unmanaged
        {
            if(size<E>() == 1)
                return e8u(src);
            else if(size<E>() == 2)
                return (byte)e16u(src);
            else if(size<E>() == 4)
                return (byte)e32u(src);
            else
                return (byte)e64u(src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ushort force16u<E>(E src)
            where E : unmanaged
        {
            if(size<E>() == 1)
                return e8u(src);
            else if(size<E>() == 2)
                return e16u(src);
            else if(size<E>() == 4)
                return (ushort)e32u(src);
            else
                return (ushort)e64u(src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static uint force32u<E>(E src)
            where E : unmanaged
        {
            if(size<E>() == 1)
                return e8u(src);
            else if(size<E>() == 2)
                return e16u(src);
            else if(size<E>() == 4)
                return e32u(src);
            else
                return (uint)e64u(src);
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ulong force64u<E>(E src)
            where E : unmanaged
        {
            if(size<E>() == 1)
                return e8u(src);
            else if(size<E>() == 2)
                return e16u(src);
            else if(size<E>() == 4)
                return e32u(src);
            else
                return e64u(src);
        }
    }
}