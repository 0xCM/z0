//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Enums
    {
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
    }
}