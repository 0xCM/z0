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
        /// <summary>
        /// Presents a <see cref='sbyte'/> as an enumeration value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E @enum<E>(sbyte src) 
            where E : unmanaged, Enum
                => @as<sbyte,E>(src);

        /// <summary>
        /// Presents a <see cref='byte'/> as and enum value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E @enum<E>(in byte src) 
            where E : unmanaged, Enum
                => @as<byte,E>(src);                

        /// <summary>
        /// Presents a <see cref='uint'/> as an enumeration value
        /// </summary>
        /// <param name="src">The enum source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E @enum<E>(uint src) 
            where E : unmanaged, Enum
                => @as<uint,E>(src);

    }
}