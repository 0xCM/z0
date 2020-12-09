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

    public readonly struct ApiSig : ITextual
    {
        public utf8 Component {get;}

        public utf8 Host {get;}

        public CliSig Member {get;}

        [MethodImpl(Inline)]
        public ApiSig(string component, string host, CliSig member)
        {
            Component = component;
            Host = host;
            Member = member;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Member.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => hash(Member.Data);
        }
        public string Format()
            => Member.Format();

        public override string ToString()
            => Format();

        public bool Equals(ApiSig src)
            => Member.Equals(src.Member);

        public override bool Equals(object obj)
            => obj is ApiSig s && Equals(s);

        public override int GetHashCode()
            => (int)Hash;

        [MethodImpl(Inline)]
        public static bool operator==(ApiSig a, ApiSig b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator!=(ApiSig a, ApiSig b)
            => !a.Equals(b);

        public static ApiSig Empty
        {
            [MethodImpl(Inline)]
            get => new ApiSig(EmptyString, EmptyString, CliSig.Empty);
        }
    }
}