//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdName : ICmdName<CmdName>
    {
        public string Content {get;}

        [MethodImpl(Inline)]
        public CmdName(string src)
            => Content = src;

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => text.empty(Content);
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => text.nonempty(Content);
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => (uint)Content.GetHashCode();
        }

        [MethodImpl(Inline)]
        public string Format()
            => Content;

        [MethodImpl(Inline)]
        public bool Equals(CmdName src)
            => text.equals(Content, src.Content);

        public override bool Equals(object obj)
            => obj is CmdName x ? Equals(x) : false;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public static bool operator ==(CmdName a, CmdName b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(CmdName a, CmdName b)
            => !a.Equals(b);

        [MethodImpl(Inline)]
        public static implicit operator CmdName(Type spec)
            => new CmdName(spec.Name);

        [MethodImpl(Inline)]
        public static implicit operator string(CmdName src)
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator CmdName(string src)
            => new CmdName(src);

        public static CmdName Empty => default;
    }
}