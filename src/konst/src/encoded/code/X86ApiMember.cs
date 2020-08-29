//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    /// <summary>
    /// Pairs an api member with the executable code derived from that member
    /// </summary>
    public readonly struct X86ApiMember : IIdentifiedCode<X86ApiMember,IdentifiedCode>
    {
        public ApiMember Member {get;}

        public IdentifiedCode Encoded {get;}

        public OpUri OpUri
        {
            [MethodImpl(Inline)]
            get => Encoded.OpUri;
        }

        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public ref readonly byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public static implicit operator BinaryCode(X86ApiMember src)
            => src.Encoded.Encoded;

        [MethodImpl(Inline)]
        public X86ApiMember(ApiMember member, IdentifiedCode code)
        {
            Member = member;
            Encoded = code;
        }

        [MethodImpl(Inline)]
        public X86ApiMember(ApiMember member, BinaryCode code)
        {
            Member = member;
            Encoded = new IdentifiedCode(member.Address, member.OpUri, code);
        }


        public OpKindId KindId
             => Member.KindId;

        public OpIdentity Id
            => Member.Id;

        public OpUri Uri
            => Member.OpUri;

        public ApiHostUri Host
             => Uri.Host;

        public MethodInfo Method
             => Member.Method;

        BinaryCode IEncoded.Encoded
            => Encoded;

        public bool Equals(X86ApiMember src)
            => Encoded.Equals(src.Encoded);

        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is X86ApiMember m && Equals(m);

        public string Format(int uripad)
            => text.concat(Member.OpUri.Format().PadRight(uripad), Encoded.Format());

        public string Format()
            => Format(80);

        public override string ToString()
            => Format();

        public static X86ApiMember Empty
            => new X86ApiMember(ApiMember.Empty, BinaryCode.Empty);
    }
}