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
        public PartId Part {get;}

        public utf8 HostName {get;}

        public CliSig MemberSig {get;}

        [MethodImpl(Inline)]
        public ApiSig(PartId part, string host, CliSig member)
        {
            Part = part;
            HostName = host;
            MemberSig = member;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => MemberSig.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => hash(MemberSig.Data);
        }
        public string Format()
            => MemberSig.Format();

        public override string ToString()
            => Format();

        public bool Equals(ApiSig src)
            => MemberSig.Equals(src.MemberSig);

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
            get => new ApiSig(0, EmptyString, CliSig.Empty);
        }
    }
}