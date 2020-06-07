//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Control;

    /// <summary>
    /// Defines an S-symbol value covered by a T-storage cell
    /// </summary>
    public readonly struct Symbol<S,T> : ISymbol<S,T>
        where S : unmanaged
        where T : unmanaged
    {                
        [MethodImpl(Inline)]
        public static explicit operator char(Symbol<S,T> src)
            => Symbolic.@char(src);

        [MethodImpl(Inline)]
        public static implicit operator S(Symbol<S,T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Symbol<S>(Symbol<S,T> src)
            => new Symbol<S>(src.Value);

        /// <summary>
        /// The symbol value
        /// </summary>
        public S Value {get;}

        [MethodImpl(Inline)]
        public Symbol(S value)
        {
            Value = value;
        }  

        public Symbol<S> Simplified
        {
            [MethodImpl(Inline)]
            get => new Symbol<S>(Value);
        }

        /// <summary>
        /// The symbol value, from storage cell persective
        /// </summary>
        public T Cell
        {
            [MethodImpl(Inline)]
            get => Unsafe.As<S,T>(ref edit(Value));
        }      
    }
}