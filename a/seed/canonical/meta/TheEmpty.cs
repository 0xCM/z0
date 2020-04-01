//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Represents the nothingness of the void
    /// </summary>
    public readonly struct TheEmpty
    {        
        /// <summary>
        /// The only one
        /// </summary>
        public static TheEmpty The => default;
    }

    /// <summary>
    /// Represents the nothingness of the parametric void
    /// </summary>
    public readonly struct TheEmpty<T>
    {
        [MethodImpl(Inline)]
        public static implicit operator TheEmpty(TheEmpty<T> src)
            => TheEmpty.The;        

        /// <summary>
        /// The only parametric one
        /// </summary>            
        [MethodImpl(Inline)]
        public static TheEmpty<T> The(T zero) => new TheEmpty<T>(zero);

        [MethodImpl(Inline)]
        TheEmpty(T zero)
        {
            Zero = zero;
        }
        
        public readonly T Zero;
    }
}