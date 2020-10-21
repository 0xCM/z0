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

    public readonly struct CmdId : ITextual
    {
        [MethodImpl(Inline)]
        public static CmdId from(Type spec)
            => new CmdId(spec.Name);

        [MethodImpl(Inline)]
        public static CmdId from<T>()
            => from(typeof(T));

        readonly StringRef Data;

        [MethodImpl(Inline)]
        public CmdId(string src)
            => Data = src;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdId(Type spec)
            => from(spec);

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.SlotDot2, Data.Format());

        public static CmdId Empty => default;
    }
}