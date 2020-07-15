//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {                                
        [MethodImpl(Inline), Op]
        public static BinaryLiteral literal(Base2 @base2, string name, object value, string text)
            => new BinaryLiteral(name,value,text);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static BinaryLiteral<T> literal<T>(Base2 @base2, string name, T value, string text)
            where T : unmanaged
                => new BinaryLiteral<T>(name, value, text);

        /// <summary>
        /// Envisions a u8 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u8-kind</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E>(in byte tVal, E eRep = default) 
            where E : unmanaged, Enum
                => ref eVal(tVal, eRep);

        /// <summary>
        /// Envisions an i8 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i8-kind</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E>(in sbyte tVal, E eRep = default) 
            where E : unmanaged, Enum
                 => ref eVal(tVal, eRep);

        /// <summary>
        /// Envisions an i16 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i16-kind</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E>(in short tVal, E eRep = default) 
            where E : unmanaged, Enum
                 => ref eVal(tVal, eRep);

        /// <summary>
        /// Envisions a u16 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u16-kind</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E>(in ushort tVal, E eRep = default) 
            where E : unmanaged, Enum
                 => ref eVal(tVal, eRep);

        /// <summary>
        /// Envisions a c16 value as a value of an enum of like u16 kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u16-kind</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E>(in char tVal, E eRep = default) 
            where E : unmanaged, Enum
                 => ref eVal(tVal, eRep);

        /// <summary>
        /// Envisions an i32 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i32-kind</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E>(in int tVal, E eRep = default) 
            where E : unmanaged, Enum
                 => ref eVal(tVal, eRep);

        /// <summary>
        /// Envisions a u32 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u32-kind</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E>(in uint tVal, E eRep = default) 
            where E : unmanaged, Enum
                 => ref eVal(tVal, eRep);

        /// <summary>
        /// Envisions an i64 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal i64-kind</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E>(in long tVal, E eRep = default) 
            where E : unmanaged, Enum
                 => ref eVal(tVal, eRep);

        /// <summary>
        /// Envisions a u64 value as a value of an enum of like primal kind
        /// </summary>
        /// <param name="tVal">The source value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum target type of primal u64-kind</typeparam>
        [MethodImpl(Inline)]
        public static ref E literal<E>(in ulong tVal, E eRep = default) 
            where E : unmanaged, Enum
                 => ref eVal(tVal, eRep);

        /// <summary>
        /// Reads an E-value from an enum of primal T-kind
        /// </summary>
        /// <param name="tVal">The integral value</param>
        /// <param name="eRep">A representative enum value, used only for type inference</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        static ref E eVal<T,E>(in T tVal, E eRep = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => ref EnumValue.literal<E,T>(tVal);            
    }
}