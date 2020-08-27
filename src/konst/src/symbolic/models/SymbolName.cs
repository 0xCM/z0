//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

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

        public static SymbolName Empty
        {
            [MethodImpl(Inline)]
            get => new SymbolName(EmptyString);
        }
    }

    public readonly struct SymbolName<S>
        where S : unmanaged
    {
        readonly StringRef Ref;

        [MethodImpl(Inline)]
        public static implicit operator SymbolName(SymbolName<S> src)
            => new SymbolName(src.Ref);

        [MethodImpl(Inline)]
        public static implicit operator SymbolName<S>(string src)
            => new SymbolName<S>(src);

        [MethodImpl(Inline)]
        public SymbolName(string src)
            => Ref = src;

        [MethodImpl(Inline)]
        public string Format()
            => Ref.Format();

        public static SymbolName<S> Empty
        {
            [MethodImpl(Inline)]
            get => new SymbolName<S>(EmptyString);
        }
    }
}