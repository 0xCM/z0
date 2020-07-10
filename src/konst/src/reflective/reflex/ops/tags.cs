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

    partial struct Reflex
    {
        /// <summary>
        /// Defines a tagged member
        /// </summary>
        /// <param name="m">The member</param>
        /// <param name="t">The tag</param>
        /// <typeparam name="M">The member type</typeparam>
        /// <typeparam name="T">The tag type</typeparam>
        [MethodImpl(Inline)]
        public static TaggedMember<M,T> tags<M,T>(M m, T t)
            where M : MemberInfo
            where T : Attribute
                => (m,t);

        public static TaggedMembers<MethodInfo,A> tags<A>(Type src)
            where A : Attribute
                => src.DeclaredMethods().Where(m => m.Tagged<A>()).Select(x => tag(x, x.Tag<A>().Require()));

        static TaggedMember<M,A> tag<M,A>(M member, A tag)
            where M : MemberInfo
            where A : Attribute
                => (member,tag);            
    }
}