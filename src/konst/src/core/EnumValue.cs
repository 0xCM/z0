//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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
        public static unsafe E literal<E,T>(T tVal, E eRep = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<E>((E*)&tVal);

        /// <summary>
        /// Reads a T-value from the value of an E-enum of primal T-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T scalar<E,T>(E eVal, T tRep = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<T>((T*)(&eVal));

        /// <summary>
        /// Reads a T-value from an E-enum value of primal T-kind. 
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T scalar<E,T>(in E eVal, out T tVal) 
            where E : unmanaged, Enum
            where T : unmanaged
        {
            tVal = to<E,T>(eVal);
            return ref tVal;
        }

        /// <summary>
        /// Reads a u8-value from an enum of primal u8-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly byte scalar<E>(in E eVal, out byte tVal) 
            where E : unmanaged, Enum
                => ref store(eVal, out tVal);

        /// <summary>
        /// Reads an i8-value from an enum of primal u8-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly sbyte scalar<E>(in E eVal, out sbyte tVal) 
            where E : unmanaged, Enum
                => ref store(eVal, out tVal);

        /// <summary>
        /// Reads an i16-value from an enum of primal i16-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly short scalar<E>(in E eVal, out short tVal) 
            where E : unmanaged, Enum
                => ref store(eVal, out tVal);

        /// <summary>
        /// Reads a u16-value from an enum of primal u16-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ushort scalar<E>(in E eVal, out ushort tVal) 
            where E : unmanaged, Enum
                => ref store(eVal, out tVal);

        /// <summary>
        /// Reads an i32-value from an enum of primal i32-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly int scalar<E>(in E eVal, out int tVal) 
            where E : unmanaged, Enum
                => ref store(eVal, out tVal);

        /// <summary>
        /// Reads a u32-value from an enum of primal u32-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly uint scalar<E>(in E eVal, out uint tVal) 
            where E : unmanaged, Enum
                => ref store(eVal, out tVal);

        /// <summary>
        /// Reads an i64-value from an enum of primal i64-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly long scalar<E>(in E eVal, out long tVal) 
            where E : unmanaged, Enum
                => ref store(eVal, out tVal);

        /// <summary>
        /// Reads a u64-value from an enum of primal u64-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ulong scalar<E>(in E eVal, out ulong tVal) 
            where E : unmanaged, Enum
                => ref store(eVal, out tVal);

        /// <summary>
        /// Reads a c16-value from an enum of primal u16-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="cVal">The character output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly char scalar<E>(in E eVal, out char cVal) 
            where E : unmanaged, Enum
        {
            cVal = (char)scalar(eVal, out ushort _);
            return ref cVal;
        }

        /// <summary>
        /// Stores an enum value of any primal kind to a u64 target
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ulong eStore<E>(in E eVal, out ulong dst) 
            where E : unmanaged, Enum
        {
            dst = 0ul;
            var eSize = size<E>();
            if(eSize == 1)
                u8(eVal, ref dst);
            else if(eSize == 2)
                u16(eVal, ref dst);
            else if(eSize == 4)
                u32(eVal, ref dst);
            else
                u64(eVal, ref dst);
            return ref dst;
        }

        /// <summary>
        /// Reads a u8 value from an enum of primal u8-kind, writes the value to a u64 target, and returns the extracted u8 value
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly byte u8<E>(in E eVal, ref ulong dst) 
            where E : unmanaged, Enum
        {
            ref readonly var tVal = ref to<E,byte>(eVal);
            dst = tVal;
            return ref tVal;
        }

        /// <summary>
        /// Reads a u8 value from an enum of primal i8-kind, writes the value to a u64 target, and returns the extracted i8 value
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly sbyte i8<E>(in E eVal, ref ulong dst) 
            where E : unmanaged, Enum
        {
            ref readonly var tVal = ref to<E,sbyte>(eVal);
            dst = (byte)tVal;
            return ref tVal;
        }

        /// <summary>
        /// Reads a u16 value from an enum of primal u16-kind, writes the value to a u64 target, and returns the extracted u16 value
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ushort u16<E>(in E eVal, ref ulong dst) 
            where E : unmanaged, Enum
        {
            ref readonly var tVal = ref to<E,ushort>(eVal);
            dst = tVal;
            return ref tVal;
        }

        /// <summary>
        /// Reads a u16 value from an enum of primal u16-kind, writes the value to a u64 target, and returns the extracted value as c16 value
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly char c16<E>(in E eVal, ref ulong dst) 
            where E : unmanaged, Enum
                => ref to<ushort,char>(u16(eVal, ref dst));

        /// <summary>
        /// Reads an i16 value from an enum of primal i16-kind, writes the value to a u64 target, and returns the extracted i16 value
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly short i16<E>(in E eVal, ref ulong dst) 
            where E : unmanaged, Enum
        {
            ref readonly var tVal = ref to<E,short>(eVal);
            dst = (ushort)tVal;
            return ref tVal;
        }

        /// <summary>
        /// Reads n u32 value from an enum of primal u32-kind, writes the value to a u64 target, and returns the extracted u32 value
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly uint u32<E>(in E eVal, ref ulong dst) 
            where E : unmanaged, Enum
        {
            ref readonly var tVal = ref to<E,uint>(eVal);
            dst = tVal;
            return ref tVal;
        }

        /// <summary>
        /// Reads an i32 value from an enum of primal i32-kind, writes the value to a u64 target, and returns the extracted i32 value
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly int i32<E>(in E eVal, ref ulong dst) 
            where E : unmanaged, Enum
        {
            ref readonly var tVal = ref to<E,int>(eVal);
            dst = (uint)tVal;
            return ref tVal;
        }

        /// <summary>
        /// Reads n u64 value from an enum of primal u64-kind, writes the value to a u64 target, and returns the extracted u64 value
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ulong u64<E>(in E eVal, ref ulong dst) 
            where E : unmanaged, Enum
        {
            ref readonly var tVal = ref to<E,ulong>(eVal);
            dst = tVal;
            return ref tVal;
        }

        /// <summary>
        /// Reads an i64 value from an enum of primal i64-kind, writes the value to a u64 target, and returns the extracted i64 value
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly long i64<E>(in E eVal, ref ulong dst) 
            where E : unmanaged, Enum
        {
            ref readonly var tVal = ref to<E,long>(eVal);
            dst = (ulong)tVal;
            return ref tVal;
        }

        /// <summary>
        /// Envisions an E-enum value of primal i8-kind as a like-kinded scalar value
        /// </summary>
        /// <param name="eVal">The enum source value</param>
        /// <typeparam name="E">The enum type of primal i8-kind</typeparam>
        [MethodImpl(Inline)]
        public static sbyte e8i<E>(E eVal) 
            where E : unmanaged, Enum
                => scalar<E,sbyte>(eVal);

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

        /// <summary>
        /// Envisions a c16 value as a value of an enum of like u16 kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u16-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(char src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,ushort>((ushort)src);

        /// <summary>
        /// Envisions an i32 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i32-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(int src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,int>(src);

        /// <summary>
        /// Envisions a u32 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u32-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(uint src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,uint>(src);

        /// <summary>
        /// Envisions an i64 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i64-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(long src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,long>(src);

        /// <summary>
        /// Envisions a u64 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u64-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(ulong src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,ulong>(src);
        
        [MethodImpl(Inline)]
        static int size<X>()
            => Unsafe.SizeOf<X>();

        [MethodImpl(Inline)]
        static ref X edit<X>(in X x)
            => ref Unsafe.AsRef(in x);

        [MethodImpl(Inline)]
        static ref Y to<X,Y>(in X x)
            => ref Unsafe.As<X,Y>(ref edit(x));

        [MethodImpl(Inline)]
        static ref readonly T store<E,T>(in E e, out T dst) 
            where E : unmanaged, Enum
            where T : unmanaged
        {
            dst = to<E,T>(e);
            return ref dst;
        }
    }
}