//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Seed;

    partial class Symbolic     
    {
        /// <summary>
        /// Defines a useful representation of an enumeration literal
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type refined by the enum</typeparam>
        /// <typeparam name="A">The asci identifier type</typeparam>
        [MethodImpl(Inline)]
        public static @enum<E,T> @enum<E,T>(MetadataToken token, int index, string identifier, E literal, T scalar)
            where E : unmanaged, Enum
            where T : unmanaged
                => new @enum<E,T>(token, index, identifier, literal, scalar);
    }
}