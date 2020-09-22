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
    public readonly struct ApiMemberHex
    {
        /// <summary>
        /// The extraction index
        /// </summary>
        public readonly uint Sequence;

        /// <summary>
        /// The member to which executable code is attached
        /// </summary>
        public readonly ApiMember Member;

        /// <summary>
        /// The extraction termination code
        /// </summary>
        public readonly ExtractTermCode TermCode;

        /// <summary>
        /// The encoded data
        /// </summary>
        public readonly ApiHex Encoded;

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
        public static implicit operator BinaryCode(ApiMemberHex src)
            => src.Encoded.Encoded;

        [MethodImpl(Inline)]
        public ApiMemberHex(ApiMember member, ApiHex code, uint seq = 0, ExtractTermCode term = 0)
        {
            Sequence = seq;
            Member = member;
            Encoded = code;
            TermCode = term;
        }

        [MethodImpl(Inline)]
        public ApiMemberHex(ApiMember member, BinaryCode code, uint seq = 0, ExtractTermCode term = 0)
        {
            Sequence = seq;
            Member = member;
            Encoded = new ApiHex(member.Address, member.OpUri, code);
            TermCode = term;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Encoded.Base;
        }

        public ApiKeyId KindId
             => Member.KindId;

        public OpIdentity Id
            => Member.Id;

        public OpUri Uri
            => Member.OpUri;

        public ApiHostUri Host
             => Uri.Host;

        public MethodInfo Method
             => Member.Method;


        public bool Equals(ApiMemberHex src)
            => Encoded.Equals(src.Encoded);

        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is ApiMemberHex m && Equals(m);

        public string Format(int uripad)
            => text.concat(Member.OpUri.Format().PadRight(uripad), Encoded.Format());

        public string Format()
            => Format(80);

        public override string ToString()
            => Format();

        public static ApiMemberHex Empty
            => new ApiMemberHex(ApiMember.Empty, BinaryCode.Empty);
    }
}