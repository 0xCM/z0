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


        [MethodImpl(Inline), Op]
        public static BinaryLiteral literal(Base2 @base2, string name, object value, string text)
            => new BinaryLiteral(name,value,text);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BinaryLiteral<T> literal<T>(Base2 @base2, string name, T value, string text)
            where T : unmanaged
                => new BinaryLiteral<T>(name, value, text);

    }
}