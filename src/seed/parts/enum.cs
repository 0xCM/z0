//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 4040
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct @enum 
    {
        /// <summary>
        /// Defines a useful representation of an enumeration literal
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type refined by the enum</typeparam>
        /// <typeparam name="A">The asci identifier type</typeparam>
        [MethodImpl(Inline)]
        public static @enum<E,T> define<E,T>(MetadataToken token, int index, string identifier, E literal, T scalar)
            where E : unmanaged, Enum
            where T : unmanaged
                => new @enum<E,T>(token, index, identifier, literal, scalar);
    }

    public readonly struct @enum<E,T>
        where E : unmanaged, Enum
        where T : unmanaged
    {
        public MetadataToken Token {get;}
        
        public int Index {get;}
        
        public string Name {get;}

        public E Literal {get;}

        public T Scalar {get;}

        [MethodImpl(Inline)]
        public @enum(MetadataToken token, int index, string name, E literal, T scalar)
        {
            Token = token;
            Index = index;
            Name = name;
            Literal = literal;
            Scalar = scalar;
        }                
    }
}