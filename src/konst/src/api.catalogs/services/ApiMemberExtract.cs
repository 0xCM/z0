//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct ApiMemberExtract
    {
        public CodeBlock Encoded {get;}

        public OpIdentity Id {get;}

        public OpUri OpUri {get;}

        public ApiMember Member {get;}

        public CliSig CliSig
        {
            [MethodImpl(Inline)]
            get => Member.CliSig;
        }

        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Code;
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
        public ApiMemberExtract(OpIdentity id, OpUri uri, ApiMember member, CodeBlock encoded)
        {
            Id = id;
            OpUri = uri;
            Member = member;
            Encoded = encoded;
        }

        [MethodImpl(Inline)]
        public ApiMemberExtract(ApiMember member, CodeBlock encoded)
            : this(member.Id, member.OpUri, member, encoded)
            {

            }

        public MethodInfo Method
            => Member.Method;

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Encoded.BaseAddress;
        }

        public ApiHostUri Host
        {
            [MethodImpl(Inline)]
            get => Member.Host;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Encoded.Format();

        [MethodImpl(Inline)]
        public bool Equals(ApiMemberExtract src)
            => Encoded.Equals(src.Encoded);

        public static ApiMemberExtract Empty
            => new ApiMemberExtract(ApiMember.Empty, CodeBlock.Empty);
    }
}