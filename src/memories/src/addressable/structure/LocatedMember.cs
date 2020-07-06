//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LocatedMember<M>
        where M : MemberInfo
    {
        public M Member {get;}

        public MemoryAddress Location {get;}

        [MethodImpl(Inline)]
        public LocatedMember(M member, MemoryAddress location)
        {
            Member = member;
            Location = location;
        }
    }
}