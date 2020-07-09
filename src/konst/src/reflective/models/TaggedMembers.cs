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

    public readonly struct TaggedMembers
    {
        public static TaggedMembers<MethodInfo,A> methods<A>(Type src)
            where A : Attribute
                => src.DeclaredMethods().Where(m => m.Tagged<A>()).Select(x => define(x, x.Tag<A>().Require()));

        public static TaggedMember<M,A> define<M,A>(M member, A tag)
            where M : MemberInfo
            where A : Attribute
                => (member,tag);
    }

    public readonly struct TaggedMembers<M,A>
        where M : MemberInfo
        where A : Attribute
    {
        [MethodImpl(Inline)]
        public static implicit operator TaggedMembers<M,A>(TaggedMember<M,A>[] src)
            => new TaggedMembers<M,A>(src);

        [MethodImpl(Inline)]
        public TaggedMembers(params TaggedMembers<M,A>[] src)
        {
            Data = src;
        }

        public TaggedMembers<M,A>[] Data {get;}
    }
}