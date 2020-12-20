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

    public readonly struct TaggedMembers<M,A>
        where M : MemberInfo
        where A : Attribute
    {
        public readonly TaggedMembers<M,A>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator TaggedMembers<M,A>(TaggedMember<M,A>[] src)
            => new TaggedMembers<M,A>(src);

        [MethodImpl(Inline)]
        public TaggedMembers(params TaggedMembers<M,A>[] src)
            => Data = src;
    }
}