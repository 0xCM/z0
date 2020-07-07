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

    public readonly struct LocatedMethod : ITextual
    {
        public MethodInfo Method {get;}

        public MemoryAddress Location {get;}

        public ByteSize Size {get;}

        public bool HasKnownSize
        {
            [MethodImpl(Inline)]
            get => Size.IsNonZero;
        }

        public MemRef MemRef
        {
            [MethodImpl(Inline)]
            get => new MemRef(Location, Size.IsEmpty ? 0 : (int)Size);
        }

        [MethodImpl(Inline)]
        public static implicit operator LocatedMethod((MethodInfo method, MemoryAddress location, int? size) src)
            => new LocatedMethod(src.method, src.location, src.size);

        [MethodImpl(Inline)]
        public static implicit operator MemRef(LocatedMethod src)
            => src.MemRef;

        [MethodImpl(Inline)]
        public LocatedMethod(MethodInfo method, MemoryAddress location, ByteSize? size = null)
        {
            Method = method;
            Location = location;
            Size = size ?? ByteSize.Empty;
        }

        public string Format()
        {
            var name = Method.DisplayName();
            var address = Location.Format();
            var size = HasKnownSize ? text.bracket(Size) : EmptyString;
            return text.concat(name,size, Space, Chars.Eq, Space, address);
        }

        public override string ToString() 
            => Format();
    }
}