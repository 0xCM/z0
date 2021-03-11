//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct BasedApiMembers : IIndex<ApiMember>
    {
        public MemoryAddress Base {get;}

        public Index<ApiMember> Members {get;}

        [MethodImpl(Inline)]
        public BasedApiMembers(MemoryAddress @base, Index<ApiMember> members)
        {
            Base = @base;
            Members = members;
        }

        public ApiMember[] Storage
        {
            [MethodImpl(Inline)]
            get => Members.Storage;
        }

        public ReadOnlySpan<ApiMember> View
        {
            [MethodImpl(Inline)]
            get => Members.View;
        }

        public ref ApiMember First
        {
            [MethodImpl(Inline)]
            get => ref Members.First;
        }

        public uint MemberCount
        {
            [MethodImpl(Inline)]
            get => Members.Count;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => MemberCount == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => MemberCount != 0;
        }


        public static BasedApiMembers Empty
        {
            [MethodImpl(Inline)]
            get => new BasedApiMembers(0, sys.empty<ApiMember>());
        }
    }
}