//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using api = SymbolStores;

    /// <summary>
    /// Defines an S-symbol value covered by a T-storage cell
    /// </summary>
    public readonly struct Symbol<S,T> : ISymbol<S,T>
        where S : unmanaged
        where T : unmanaged
    {
        /// <summary>
        /// The symbol value
        /// </summary>
        public S Value {get;}

        [MethodImpl(Inline)]
        public Symbol(S src)
            => Value = src;

        public Identifier Name
        {
            [MethodImpl(Inline)]
            get => Value.ToString();
        }

        /// <summary>
        /// The symbol value, from storage cell perspective
        /// </summary>
        public T Cell
        {
            [MethodImpl(Inline)]
            get => @as<S,T>(Value);
        }

        public Symbol<S> Simplified
        {
            [MethodImpl(Inline)]
            get => new Symbol<S>(Value);
        }

        public Type ValueType
            => typeof(S);

        public Type CellType
            => typeof(T);

        [MethodImpl(Inline)]
        public static explicit operator char(Symbol<S,T> src)
            => api.render(src);

        [MethodImpl(Inline)]
        public static implicit operator S(Symbol<S,T> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Symbol<S>(Symbol<S,T> src)
            => new Symbol<S>(src.Value);
    }
}