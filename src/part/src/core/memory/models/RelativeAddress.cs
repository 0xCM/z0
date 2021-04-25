//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RelativeAddress
    {
        public MemoryAddress Base {get;}

        public ulong Offset {get;}

        [MethodImpl(Inline)]
        internal RelativeAddress(MemoryAddress @base, ulong offset)
        {
            Base = @base;
            Offset = offset;
        }

        public MemoryAddress Absolute
        {
             [MethodImpl(Inline)]
             get => Base + Offset;
        }

        public bool IsEmpty
        {
             [MethodImpl(Inline)]
             get => Absolute == 0;
        }

        public bool IsNonEmpty
        {
             [MethodImpl(Inline)]
             get => !IsEmpty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => AddressParser.format(this);

        [MethodImpl(Inline)]
        public bool Equals(RelativeAddress src)
            => Absolute == src.Absolute;

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Offset.GetHashCode();

        public override bool Equals(object src)
            => src is RelativeAddress l && Equals(l);

        [MethodImpl(Inline)]
        public static RelativeAddress operator+(RelativeAddress x, byte y)
            => new RelativeAddress(x.Base, x.Offset + y);

        [MethodImpl(Inline)]
        public static RelativeAddress operator+(RelativeAddress x, ushort y)
            => new RelativeAddress(x.Base, x.Offset + y);

        [MethodImpl(Inline)]
        public static RelativeAddress operator+(RelativeAddress x, uint y)
            => new RelativeAddress(x.Base, x.Offset + y);

        [MethodImpl(Inline)]
        public static RelativeAddress operator-(RelativeAddress x, byte y)
            => new RelativeAddress(x.Base, x.Offset - y);

        [MethodImpl(Inline)]
        public static RelativeAddress operator-(RelativeAddress x, ushort y)
            => new RelativeAddress(x.Base, x.Offset - y);

        [MethodImpl(Inline)]
        public static RelativeAddress operator-(RelativeAddress x, uint y)
            => new RelativeAddress(x.Base, x.Offset - y);

        [MethodImpl(Inline)]
        public static bool operator==(RelativeAddress x, RelativeAddress y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelativeAddress x, RelativeAddress y)
            => !x.Equals(y);

        public static RelativeAddress Empty
            => default;
    }
}