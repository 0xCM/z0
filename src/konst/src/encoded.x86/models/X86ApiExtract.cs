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
    /// Defines a contiguous sequence of based x86-encoded bytes associated with a <see cref='ApiMember'/>
    /// </summary>
    public readonly struct X86ApiExtract
    {
        public readonly X86Code Encoded;

        public readonly OpIdentity Id;

        public readonly OpUri OpUri;

        public readonly ApiMember Member;

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
        public X86ApiExtract(OpIdentity id, OpUri uri, ApiMember member, X86Code encoded)
        {
            Id = id;
            OpUri = uri;
            Member = member;
            Encoded = encoded;
        }

        [MethodImpl(Inline)]
        public X86ApiExtract(ApiMember member, X86Code encoded)
            : this(member.Id, member.OpUri, member, encoded)
            {

            }

        public MethodInfo Method
            => Member.Method;

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Encoded.Base;
        }

        public ApiHostUri Host
        {
            [MethodImpl(Inline)]
            get => Member.HostUri;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Encoded.Format();

        [MethodImpl(Inline)]
        public bool Equals(X86ApiExtract src)
            => Encoded.Equals(src.Encoded);

        public static X86ApiExtract Empty
            => new X86ApiExtract(ApiMember.Empty, X86Code.Empty);
    }
}