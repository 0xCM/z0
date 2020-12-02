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

    public readonly struct MemberAddress : IAddressable<MemberAddress, MemoryAddress>, IComparable<MemberAddress>
    {
        public static unsafe MemberAddress from(MethodInfo src)
            => new MemberAddress(src, src.MethodHandle.Value.ToPointer());

        public static unsafe MemberAddress from(FieldInfo src)
            => new MemberAddress(src, src.FieldHandle.Value.ToPointer());

        public MemoryAddress Address {get;}

        public ClrMember Member {get;}

        [MethodImpl(Inline)]
        public MemberAddress(ClrMember member, MemoryAddress address)
        {
            Member = member;
            Address = address;
        }

        public string Format()
            => string.Format("{0}: {1}", Address, Member.Name);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public int CompareTo(MemberAddress src)
            => Address.CompareTo(src.Address);

        [MethodImpl(Inline)]
        public static implicit operator MemberAddress(Paired<ClrMember,MemoryAddress> src)
            => new MemberAddress(src.Left, src.Right);
    }
}