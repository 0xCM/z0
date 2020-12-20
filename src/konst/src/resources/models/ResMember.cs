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
    /// Describes a member that defines a resource
    /// </summary>
    public readonly struct ResMember : ITextual
    {
        public MemberInfo Member {get;}

        public MemorySegment Reference {get;}

        [MethodImpl(Inline)]
        public ResMember(MemberInfo member, MemorySegment seg)
        {
            Member = member;
            Reference = seg;
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