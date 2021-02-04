//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct LocatedMethod : ITextual, IComparable<LocatedMethod>
    {
        public OpIdentity Id {get;}

        public MethodInfo Method {get;}

        public MemoryAddress Address {get;}

        public ByteSize Size {get;}

        public bool HasKnownSize
        {
            [MethodImpl(Inline)]
            get => Size.IsNonZero;
        }

        public MemorySegment MemRef
        {
            [MethodImpl(Inline)]
            get => new MemorySegment(Address, Size.IsEmpty ? 0 : (int)Size);
        }

        [MethodImpl(Inline)]
        public static implicit operator MemorySegment(LocatedMethod src)
            => src.MemRef;

        [MethodImpl(Inline)]
        public LocatedMethod(OpIdentity id, MethodInfo method, MemoryAddress location)
        {
            Id = id;
            Method = method;
            Address = location;
            Size = ByteSize.Empty;
        }

        public string Format()
        {
            var name = Method.DisplayName();
            var address = Address.Format();
            var size = HasKnownSize ? text.bracket(Size) : EmptyString;
            return text.concat(name,size, Space, Chars.Eq, Space, address);
        }

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public int CompareTo(LocatedMethod src)
            => Address.CompareTo(src.Address);
    }
}