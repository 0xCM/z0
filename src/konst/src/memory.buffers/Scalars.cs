//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.Scalars, true)]
    public readonly struct Scalars
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Interprets a scalar value of one sort as a scalar value of another
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T scalar<S,T>(in S src)
            where S : unmanaged
            where T : unmanaged
                => ref @as<S,T>(src);

        /// <summary>
        /// Reads a T-value from an E-enum value of primal T-kind.
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target output value</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T scalar<E,T>(in E src, out T dst)
            where E : unmanaged
            where T : unmanaged
        {
            dst = z.@as<E,T>(src);
            return ref dst;
        }

        /// <summary>
        /// Reads a u8-value from an enum of primal u8-kind
        /// </summary>
        /// <param name="src">The enum value</param>
        /// <param name="dst">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte scalar<S>(in S src, out byte dst)
            where S : unmanaged
                => ref ScalarStore.store(src, out dst);

        /// <summary>
        /// Reads an i8-value from an enum of primal u8-kind
        /// </summary>
        /// <param name="src">The enum value</param>
        /// <param name="dst">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref sbyte scalar<S>(in S src, out sbyte dst)
            where S : unmanaged
                => ref ScalarStore.store(src, out dst);

        /// <summary>
        /// Reads an i16-value from an enum of primal i16-kind
        /// </summary>
        /// <param name="src">The enum value</param>
        /// <param name="dst">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref short scalar<S>(in S src, out short dst)
            where S : unmanaged
                => ref ScalarStore.store(src, out dst);

        /// <summary>
        /// Reads a u16-value from an enum of primal u16-kind
        /// </summary>
        /// <param name="src">The enum value</param>
        /// <param name="dst">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort scalar<S>(in S src, out ushort dst)
            where S : unmanaged
                => ref ScalarStore.store(src, out dst);

        /// <summary>
        /// Reads an i32-value from an enum of primal i32-kind
        /// </summary>
        /// <param name="src">The enum value</param>
        /// <param name="dst">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref int scalar<S>(in S src, out int dst)
            where S : unmanaged
                => ref ScalarStore.store(src, out dst);

        /// <summary>
        /// Reads a u32-value from an enum of primal u32-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint scalar<S>(in S eVal, out uint tVal)
            where S : unmanaged
                => ref ScalarStore.store(eVal, out tVal);

        /// <summary>
        /// Reads an i64-value from an enum of primal i64-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref long scalar<S>(in S eVal, out long tVal)
            where S : unmanaged
                => ref ScalarStore.store(eVal, out tVal);

        /// <summary>
        /// Reads a u64-value from an enum of primal u64-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong scalar<S>(in S eVal, out ulong tVal)
            where S : unmanaged
                => ref ScalarStore.store(eVal, out tVal);

        /// <summary>
        /// Reads a c16-value from an enum of primal u16-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="cVal">The character output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref char scalar<S>(in S eVal, out char cVal)
            where S : unmanaged
        {
            cVal = (char)scalar(eVal, out ushort _);
            return ref cVal;
        }
    }
}