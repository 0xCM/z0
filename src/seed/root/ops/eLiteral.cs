//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class RootLegacy
    {                

        /// <summary>
        /// Advances to a T-cell predicated on the numeric value of an E-literal, which does not necessarily refine a T-primal
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="field">The enumeration literal</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static ref T eSeek<E,T>(Span<T> src, E field)
            where E : unmanaged, Enum
                => ref As.seek(src, scalar<E,ushort>(field));          

        [MethodImpl(Inline)]
        public static ref readonly T eSkip<E,T>(ReadOnlySpan<T> src, E field)
            where E : unmanaged, Enum
                => ref As.skip(src, scalar<E,ushort>(field));                    

        /// <summary>
        /// Stores an enum value of any primal kind to a u64 target
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="dst">The storage target</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly ulong eStore<E>(in E eVal, out ulong tVal) 
            where E : unmanaged, Enum
                => ref EnumValue.eStore(eVal, out tVal);
                        
        [MethodImpl(Inline), Op]
        public static BinaryLiteral literal(Base2 @base2, string name, object value, string text)
            => new BinaryLiteral(name,value,text);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryLiteral<T> literal<T>(Base2 @base2, string name, T value, string text)
            where T : unmanaged
                => new BinaryLiteral<T>(name, value, text);

        /// <summary>
        /// Reads a T-value from the value of an E-enum of primal T-kind
        /// </summary>
        /// <param name="eVal">The enum value</param>
        /// <param name="tVal">The primal output value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T scalar<E,T>(E eVal)
            where E : unmanaged, Enum
            where T : unmanaged
                => EnumValue.scalar<E,T>(eVal);

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
                => EnumValue.literal(tVal,eRep);
                
        /// <summary>
        /// Envisions a u8 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u8-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(byte tVal, E eRep = default) 
            where E : unmanaged, Enum
                => EnumValue.eVal(tVal,eRep);

        /// <summary>
        /// Envisions an i8 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i8-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(sbyte tVal, E eRep = default) 
            where E : unmanaged, Enum
                => EnumValue.eVal(tVal,eRep);

        /// <summary>
        /// Envisions an i16 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i16-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(short tVal, E eRep = default) 
            where E : unmanaged, Enum
                => EnumValue.eVal(tVal,eRep);

        /// <summary>
        /// Envisions a u16 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u16-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(ushort tVal, E eRep = default) 
            where E : unmanaged, Enum
                => EnumValue.eVal(tVal,eRep);

        /// <summary>
        /// Envisions a c16 value as a value of an enum of like u16 kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u16-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(char tVal, E eRep = default) 
            where E : unmanaged, Enum
                => EnumValue.literal(tVal,eRep);

        /// <summary>
        /// Envisions an i32 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i32-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(int tVal, E eRep = default) 
            where E : unmanaged, Enum
                => EnumValue.literal(tVal,eRep);

        /// <summary>
        /// Envisions a u32 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u32-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(uint tVal, E eRep = default) 
            where E : unmanaged, Enum
                => EnumValue.literal(tVal,eRep);

        /// <summary>
        /// Envisions an i64 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i64-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(long tVal, E eRep = default) 
            where E : unmanaged, Enum
                => EnumValue.literal(tVal,eRep);

        /// <summary>
        /// Envisions a u64 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u64-kind</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(ulong tVal, E eRep = default) 
            where E : unmanaged, Enum
                => EnumValue.literal(tVal,eRep);
    }
}