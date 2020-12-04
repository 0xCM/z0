//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using api = Addresses;

    public readonly struct RelativeAddress : IRelativeAddress<RelativeAddress>
    {
        public readonly uint Offset {get;}

        public DataWidth Grain {get;}

        [MethodImpl(Inline)]
        internal RelativeAddress(uint offset, DataWidth grain)
        {
            Offset = offset;
            Grain = grain;
        }

        public bool IsEmpty
        {
             [MethodImpl(Inline)]
             get => Offset == 0;
        }

        public bool IsNonEmpty
        {
             [MethodImpl(Inline)]
             get => Offset != 0;
        }

        public RelativeAddress Zero
        {
             [MethodImpl(Inline)]
             get => Empty;
        }

        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        [MethodImpl(Inline)]
        public bool Equals(RelativeAddress src)
            => api.equals(this, src);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => Offset.GetHashCode();

        public override bool Equals(object src)
            => src is RelativeAddress l && Equals(l);

        [MethodImpl(Inline)]
        public static RelativeAddress operator+(RelativeAddress x, byte y)
            => api.relative((byte)(x.Offset + y));

        [MethodImpl(Inline)]
        public static RelativeAddress operator+(RelativeAddress x, ushort y)
            => api.relative((ushort)(x.Offset + y));

        [MethodImpl(Inline)]
        public static RelativeAddress operator+(RelativeAddress x, uint y)
            => api.relative(x.Offset + y);

        [MethodImpl(Inline)]
        public static bool operator==(RelativeAddress x, RelativeAddress y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelativeAddress x, RelativeAddress y)
            => !x.Equals(y);

        public static RelativeAddress Empty
            => new RelativeAddress(0, 0);
    }
}