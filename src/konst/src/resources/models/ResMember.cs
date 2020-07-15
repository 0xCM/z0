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
        public readonly MemberInfo Member;

        public readonly MemRef Reference;
        
        [MethodImpl(Inline)]
        public ResMember(MemberInfo member, in MemRef memref)
        {
            Member = member;
            Reference = memref;
        }

        public MemoryAddress Address 
        {
            [MethodImpl(Inline)]
            get => Reference.Address;
        }

        public uint DataSize 
        {
            [MethodImpl(Inline)]
            get => Reference.DataSize;
        }

        public string Format()
            => $"{Member.Name} {Reference.Format()}";
    }
}