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
        public ApiExtractBlock Block {get;}

        public OpIdentity Id {get;}

        public OpUri OpUri {get;}

        public ApiMember Member {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Block.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Block.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public ApiMemberExtract(ApiMember member, ApiExtractBlock block)
        {
            Id = member.Id;
            OpUri = member.OpUri;
            Member = member;
            Block = block;
        }

        public MethodInfo Method
            => Member.Method;

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => Block.BaseAddress;
        }

        public ApiHostUri Host
        {
            [MethodImpl(Inline)]
            get => Member.Host;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Block.Format();

        [MethodImpl(Inline)]
        public bool Equals(ApiMemberExtract src)
            => Block.Equals(src.Block);

        public static ApiMemberExtract Empty
            => new ApiMemberExtract(ApiMember.Empty, ApiExtractBlock.Empty);
    }
}