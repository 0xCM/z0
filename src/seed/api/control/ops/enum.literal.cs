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
        /// Reads a generic enum member from a generic value
        /// </summary>
        /// <param name="scalar">The scalar value</param>
        /// <param name="rep">A representative value, used only for type inference</param>
        /// <typeparam name="E">The enum target type</typeparam>
        /// <typeparam name="T">The scalar source type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe E literal<E,T>(T scalar, E rep = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<E>((E*)&scalar);

        /// <summary>
        /// Presents a U8 value as an enum literal
        /// </summary>
        /// <param name="src">The scalar source value</param>
        /// <param name="rep">A representative value, used only for type inference</param>
        /// <typeparam name="E">The enum target type</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(byte src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,byte>(src);

        /// <summary>
        /// Presents a I8 value as an enum literal
        /// </summary>
        /// <param name="src">The scalar source value</param>
        /// <param name="rep">A representative value, used only for type inference</param>
        /// <typeparam name="E">The enum target type</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(sbyte src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,sbyte>(src);

        /// <summary>
        /// Presents a I16 value as an enum literal
        /// </summary>
        /// <param name="src">The scalar source value</param>
        /// <param name="rep">A representative value, used only for type inference</param>
        /// <typeparam name="E">The enum target type</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(short src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,short>(src);

        /// <summary>
        /// Presents a I16 value as an enum literal
        /// </summary>
        /// <param name="src">The scalar source value</param>
        /// <param name="rep">A representative value, used only for type inference</param>
        /// <typeparam name="E">The enum target type</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(ushort src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,ushort>(src);

        /// <summary>
        /// Presents a C16 value as an enum literal
        /// </summary>
        /// <param name="src">The scalar source value</param>
        /// <param name="rep">A representative value, used only for type inference</param>
        /// <typeparam name="E">The enum target type</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(char src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,ushort>((ushort)src);

        /// <summary>
        /// Presents a I32 value as an enum literal
        /// </summary>
        /// <param name="src">The scalar source value</param>
        /// <param name="rep">A representative value, used only for type inference</param>
        /// <typeparam name="E">The enum target type</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(int src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,int>(src);

        /// <summary>
        /// Presents a U32 value as an enum literal
        /// </summary>
        /// <param name="src">The scalar source value</param>
        /// <param name="rep">A representative value, used only for type inference</param>
        /// <typeparam name="E">The enum target type</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(uint src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,uint>(src);

        /// <summary>
        /// Presents a I64 value as an enum literal
        /// </summary>
        /// <param name="src">The scalar source value</param>
        /// <param name="rep">A representative value, used only for type inference</param>
        /// <typeparam name="E">The enum target type</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(long src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,long>(src);

        /// <summary>
        /// Presents a U64 value as an enum literal
        /// </summary>
        /// <param name="src">The scalar source value</param>
        /// <param name="rep">A representative value, used only for type inference</param>
        /// <typeparam name="E">The enum target type</typeparam>
        [MethodImpl(Inline)]
        public static E literal<E>(ulong src, E rep = default) 
            where E : unmanaged, Enum
                => literal<E,ulong>(src);
    }
}