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

    using NK = NumericKind;

    [ApiHost]
    public readonly partial struct EnumValue
    {
        public static ulong untyped<E>(E src)
            where E : unmanaged, Enum
                => typeof(E).GetEnumUnderlyingType().NumericKind() switch {
                    NK.U8 => (ulong)EnumValue.e8u(src),
                    NK.I8 => (ulong)EnumValue.e8i(src),
                    NK.U16 => (ulong)EnumValue.e16u(src),
                    NK.I16 => (ulong)EnumValue.e16i(src),
                    NK.U32 => (ulong)EnumValue.e32u(src),
                    NK.I32 => (ulong)EnumValue.e32i(src),
                    NK.I64 => (ulong)EnumValue.e64i(src),
                    NK.U64 => EnumValue.e64u(src),
                    _ => 0ul,
                };

        public static Index<E> literals<E>()
            where E : unmanaged, Enum
        {
            var fields = @readonly(typeof(E).LiteralFields());
            var count = fields.Length;
            var buffer = alloc<E>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
            {
                ref readonly var field = ref skip(fields,i);
                seek(dst, i) = (E)field.GetRawConstantValue();
            }
            return buffer;
        }

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
    }
}