//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
 
    using static Components;

    public static partial class TypeNats
    {        
        /// <summary>
        /// Defines a digit relative to a natural base
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The digit's enumeration type</typeparam>
        /// <typeparam name="N">The natural base type</typeparam>
        [MethodImpl(Inline)]   
        public static Digit<N,T> digit<N,T>(T src, N @base = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Digit<N,T>(src);

        /// <summary>
        /// Constructs a natural representative for a specified parametric type
        /// </summary>
        /// <typeparam name="K">The representative type to construct</typeparam>
        [MethodImpl(Inline)]   
        public static K nat<K>(K k = default)
            where K : unmanaged, ITypeNat
                => default;

        /// <summary>
        /// Constructs the natural type corresponding to an integral value
        /// </summary>
        /// <param name="digits">The source digits</param>
        [MethodImpl(Inline)]       
        public static NatSeq reflect(ulong value)        
            => seq(digits(value));        
    }
}