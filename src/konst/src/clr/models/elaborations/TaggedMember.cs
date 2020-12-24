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

    /// <summary>
    /// Pairs a member attribute value with its target
    /// </summary>
    public readonly struct TaggedMember<M,A>
        where M : MemberInfo
        where A : Attribute
    {
        /// <summary>
        /// The target member
        /// </summary>
        public readonly M Member;

        /// <summary>
        /// The tag value
        /// </summary>
        public readonly A Tag;

        [MethodImpl(Inline)]
        public TaggedMember(M member, A tag)
        {
            Member = member;
            Tag = tag;
        }

        [MethodImpl(Inline)]
        public static implicit operator TaggedMember<M,A>((M member, A tag) src)
            => new TaggedMember<M,A>(src.member, src.tag);
    }
}