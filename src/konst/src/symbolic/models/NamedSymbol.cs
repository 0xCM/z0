//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures a symbol name assignment
    /// </summary>
    public readonly struct NamedSymbol<S> : ITextual
        where S : unmanaged
    {
        public readonly S Symbol;

        public readonly SymbolName Name;

        [MethodImpl(Inline)]
        public NamedSymbol(S symbol, string name)
        {
            Name = name;
            Symbol = symbol;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Name.Format();

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Name.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public static implicit operator NamedSymbol<S>((S symbol, string name) src)
            => new NamedSymbol<S>(src.symbol, src.name);

        public static NamedSymbol<S> Empty
        {
            [MethodImpl(Inline)]
            get => new NamedSymbol<S>(default(S), EmptyString);
        }
    }
}