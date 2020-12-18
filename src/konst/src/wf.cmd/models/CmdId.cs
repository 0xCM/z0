//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdId : ITextual, IEquatable<CmdId>, INullity, IHashed
    {
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
            get => (uint)Data.GetHashCode();
        }

        [MethodImpl(Inline)]
        public string Format()
            => Data;

        [MethodImpl(Inline)]
        public bool Equals(CmdId src)
            => text.equals(Data, src.Data);

        public override bool Equals(object obj)
            => obj is CmdId x ? Equals(x) : false;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public static bool operator ==(CmdId a, CmdId b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(CmdId a, CmdId b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator CmdId(Type spec)
            => Cmd.id(spec);

        [MethodImpl(Inline)]
        public static implicit operator CmdName(CmdId src)
            => Cmd.name(src.Data);

        [MethodImpl(Inline)]
        public static implicit operator CmdId(CmdName src)
            => new CmdId(src.Content);

        public static CmdId Empty => default;
    }
}