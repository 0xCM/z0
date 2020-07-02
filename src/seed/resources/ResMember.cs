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
    
    public readonly struct ResMember : ITextual
    {
        public MemberInfo Member {get;}

        public MemRef Reference {get;}
        
        public MemoryAddress Address 
            => Reference.Location;

        public ByteSize Size 
            => Reference.Length;

        [MethodImpl(Inline)]
        public static ResMember Define(MemberInfo member, MemRef memref)
            => new ResMember(member, memref);

        [MethodImpl(Inline)]
        public ResMember(MemberInfo member, MemRef memref)
        {
            Member = member;
            Reference = memref;
        }

        public string Format()
            => $"{Member.Name} {Reference.Format()}";
    }
}