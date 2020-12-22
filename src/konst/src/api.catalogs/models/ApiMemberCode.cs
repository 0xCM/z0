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
    public readonly struct ApiMemberCode
    {
        /// <summary>
        /// The extraction index
        /// </summary>
        public uint Sequence {get;}

        /// <summary>
        /// The member to which executable code is attached
        /// </summary>
        public ApiMember Member {get;}

        /// <summary>
        /// The extraction termination code
        /// </summary>
        public ExtractTermCode TermCode {get;}

        /// <summary>
        /// The encoded data
        /// </summary>
        public ApiCodeBlock Encoded {get;}

        public CliSig ApiSig
        {
            [MethodImpl(Inline)]
            get => Member.ApiSig;
        }

        public OpUri OpUri
        {
            [MethodImpl(Inline)]
            get => Encoded.OpUri;
        }

        public ApiMetadataUri MetaUri
        {
            [MethodImpl(Inline)]
            get => Member.MetaUri;
        }

        public byte[] Storage
        {
            [MethodImpl(Inline)]
            get => Encoded.Storage;
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
        public static implicit operator BinaryCode(ApiMemberCode src)
            => src.Encoded.Encoded;

        [MethodImpl(Inline)]
        public ApiMemberCode(ApiMember member, ApiCodeBlock code, uint seq = 0, ExtractTermCode term = 0)
        {
            Sequence = seq;
            Member = member;
            Encoded = code;
            TermCode = term;
        }

        [MethodImpl(Inline)]
        public ApiMemberCode(ApiMember member, BinaryCode code, uint seq = 0, ExtractTermCode term = 0)
        {
            Sequence = seq;
            Member = member;
            Encoded = new ApiCodeBlock(member.Address, member.OpUri, code, member.ApiSig);
            TermCode = term;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Encoded.BaseAddress;
        }

        public ApiClass KindId
             => Member.ApiKind;

        public OpIdentity Id
            => Member.Id;

        public OpUri Uri
            => Member.OpUri;

        public ApiHostUri Host
             => Uri.Host;

        public MethodInfo Method
             => Member.Method;


        public bool Equals(ApiMemberCode src)
            => Encoded.Equals(src.Encoded);

        public override int GetHashCode()
            => Uri.GetHashCode();

        public override bool Equals(object src)
            => src is ApiMemberCode m && Equals(m);

        public string Format(int uripad)
            => text.concat(Member.OpUri.Format().PadRight(uripad), Encoded.Format());

        public string Format()
            => Format(80);

        public override string ToString()
            => Format();

        public static ApiMemberCode Empty
            => new ApiMemberCode(ApiMember.Empty, BinaryCode.Empty);
    }
}