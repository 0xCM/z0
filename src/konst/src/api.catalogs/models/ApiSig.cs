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
        public ClrArtifactKind SubjectType {get;}

        public CliSig Part {get;}

        public CliSig Host {get;}

        public CliSig Member {get;}

        [MethodImpl(Inline)]
        public ApiSig(ClrArtifactKind kind, CliSig member)
        {
            SubjectType = kind;
            Part = CliSig.Empty;
            Host = CliSig.Empty;
            Member = member;
        }

        [MethodImpl(Inline)]
        public ApiSig(ClrArtifactKind kind, CliSig part, CliSig host, CliSig member)
        {
            SubjectType = kind;
            Part = part;
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

        public bool Rooted
        {
            [MethodImpl(Inline)]
            get => Part.IsNonEmpty && Host.IsNonEmpty;
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
            get => new ApiSig(0, CliSig.Empty);
        }
    }
}