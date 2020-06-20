//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EnumInfo 
    {     
        /// <summary>
        /// Defines a useful representation of an enumeration literal
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type refined by the enum</typeparam>
        /// <typeparam name="A">The asci identifier type</typeparam>
        [MethodImpl(Inline)]
        public static EnumInfo<E,T> define<E,T>(MetadataToken token, int index, string identifier, E literal, T scalar)
            where E : unmanaged, Enum
            where T : unmanaged
                => new EnumInfo<E,T>(token, index, identifier, literal, scalar);
    } 
}