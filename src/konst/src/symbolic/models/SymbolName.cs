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
    /// Defines the name of a symbol
    /// </summary>
    public readonly struct SymbolName
    {
        readonly StringRef Ref;

        [MethodImpl(Inline)]
        public static implicit operator SymbolName(string src)
            => new SymbolName(src);

        [MethodImpl(Inline)]
        public SymbolName(string src)
            => Ref = src;

        [MethodImpl(Inline)]
        internal SymbolName(StringRef src)
            => Ref = src;

        [MethodImpl(Inline)]
        public string Format()
            => Ref.Format();

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Ref.IsNonEmpty;
        }

        public static SymbolName Empty
        {
            [MethodImpl(Inline)]
            get => new SymbolName(EmptyString);
        }
    }
}