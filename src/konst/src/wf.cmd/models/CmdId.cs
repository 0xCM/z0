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
            => new CmdId(typeof(T).Name);

        readonly string Data;

        [MethodImpl(Inline)]
        public CmdId(string src)
            => Data = src;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Data);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Data);
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => text.hash(Data);
        }

        [MethodImpl(Inline)]
        public static implicit operator CmdId(Type spec)
            => from(spec);

        [MethodImpl(Inline)]
        public string Format()
            => Data;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        public static CmdId Empty => default;
    }
}