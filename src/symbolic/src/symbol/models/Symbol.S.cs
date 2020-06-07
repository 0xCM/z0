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
    /// Defines an S-symbol value
    /// </summary>
    public readonly struct Symbol<S> : ISymbol<S>
        where S : unmanaged
    {                
        [MethodImpl(Inline)]
        public static explicit operator char(Symbol<S> src)
            => Symbolic.@char(src);

        [MethodImpl(Inline)]
        public static implicit operator S(Symbol<S> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Symbol<S>(S src)
            => new Symbol<S>(src);

        /// <summary>
        /// The symbol value
        /// </summary>
        public S Value {get;}

        [MethodImpl(Inline)]
        public Symbol(S value)
        {
            Value = value;
        }        
    }
}