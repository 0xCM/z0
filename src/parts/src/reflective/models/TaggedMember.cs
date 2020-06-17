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

    public readonly struct TaggedMember
    {
        /// <summary>
        /// Defines a tagged member
        /// </summary>
        /// <param name="m">The member</param>
        /// <param name="t">The tag</param>
        /// <typeparam name="M">The member type</typeparam>
        /// <typeparam name="T">The tag type</typeparam>
        [MethodImpl(Inline)]
        public static TaggedMember<M,T> define<M,T>(M m, T t)
            where M : MemberInfo
            where T : Attribute
                => (m,t);
    }

    /// <summary>
    /// Pairs a member attribute value with its target
    /// </summary>
    public readonly struct TaggedMember<M,A> : IPaired<M,A>
        where M : MemberInfo
        where A : Attribute
    {
        /// <summary>
        /// The target member
        /// </summary>
        public M Member {get;}

        /// <summary>
        /// The tag value
        /// </summary>
        public A Tag {get;}

        [MethodImpl(Inline)]
        public static implicit operator TaggedMember<M,A>((M member, A tag) src)
            => new TaggedMember<M,A>(src.member, src.tag);
        
        [MethodImpl(Inline)]
        public TaggedMember(M member, A tag)
        {
            Member = member;
            Tag = tag;
        }
        
        M IPaired<M,A>.Left 
            => Member;

        A IPaired<M,A>.Right 
            => Tag;
    }
}