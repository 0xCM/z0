//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = Symbolic;

    /// <summary>
    /// Defines an S-symbol value, of bit-width N, covered by a T-storage cell
    /// </summary>
    public readonly struct Symbol<S,T,N> : ISymbolic<Symbol<S,T,N>, S,T,N>
        where S : unmanaged
        where T : unmanaged
        where N : unmanaged, ITypeNat
    {
        /// <summary>
        /// The symbol value
        /// </summary>
        public readonly S Value;

        [MethodImpl(Inline)]
        public static explicit operator char(Symbol<S,T,N> src)
            => api.@char(src);

        [MethodImpl(Inline)]
        public static implicit operator S(Symbol<S,T,N> src)
            => src.Value;

        [MethodImpl(Inline)]
        public static implicit operator Symbol<S>(Symbol<S,T,N> src)
            => new Symbol<S>(src.Value);

        [MethodImpl(Inline)]
        public static implicit operator Symbol<S,T>(Symbol<S,T,N> src)
            => new Symbol<S,T>(src.Value);

        [MethodImpl(Inline)]
        public Symbol(S src)
            => Value = src;

        public Symbol<S> Simplified
        {
            [MethodImpl(Inline)]
            get => new Symbol<S>(Value);
        }

        /// <summary>
        /// The symbol value, from storage cell perspective
        /// </summary>
        public T Cell
        {
            [MethodImpl(Inline)]
            get => Unsafe.As<S,T>(ref edit(Value));
        }

        /// <summary>
        /// The bit-width of a symbol
        /// </summary>
        public static ushort SymWidth
        {
            [MethodImpl(Inline)]
            get => (ushort)nat64u<N>();
        }

        /// <summary>
        /// The bit-width of a storage cell
        /// </summary>
        public static ushort SegWidth
        {
            get => (ushort)bitwidth<T>();
        }

        /// <summary>
        /// The maximum number of symbols that can be packed into a storage cell
        /// </summary>
        public static ushort Capacity
        {
            [MethodImpl(Inline)]
            get => (ushort)(SegWidth/SymWidth);
        }

        public char Character
        {
            [MethodImpl(Inline)]
            get => api.@char(this);
        }

        S ISymbol<S>.Value
            => Value;
    }
}