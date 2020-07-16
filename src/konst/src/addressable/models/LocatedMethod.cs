//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static Konst;

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

        public MemRef MemRef
        {
            [MethodImpl(Inline)]
            get => new MemRef(Address, Size.IsEmpty ? 0 : (int)Size);
        }

        [MethodImpl(Inline)]
        public static implicit operator MemRef(LocatedMethod src)
            => src.MemRef;

        [MethodImpl(Inline)]
        public LocatedMethod(OpIdentity id, MethodInfo method, MemoryAddress location, ByteSize? size = null)
        {
            Id = id;
            Method = method;
            Address = location;
            Size = size ?? ByteSize.Empty;
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