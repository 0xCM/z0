//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;
    
    public readonly struct ResourceMember : ITextual
    {
        public MemberInfo Member {get;}

        public MemoryRef Reference {get;}
        
        public MemoryAddress Address => Reference.Address;

        public ByteSize Size => Reference.Length;

        [MethodImpl(Inline)]
        public static ResourceMember Define(MemberInfo member, MemoryRef memref)
            => new ResourceMember(member, memref);

        [MethodImpl(Inline)]
        public ResourceMember(MemberInfo member, MemoryRef memref)
        {
            Member = member;
            Reference = memref;
        }

        public string Format()
            => $"{Member.Name} {Reference.Format()}";
    }
}