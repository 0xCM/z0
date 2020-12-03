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

    public readonly struct RelativeAddress<T> : INullary<RelativeAddress<T>>, ITextual, INullity
        where T : unmanaged
    {
        public T Offset {get;}

        [MethodImpl(Inline)]
        internal RelativeAddress(T offset)
            => Offset = offset;

        public DataWidth Grain
        {
            [MethodImpl(Inline)]
            get => memory.bitsize<T>();
        }

        public bool IsEmpty
        {
             [MethodImpl(Inline)]
             get => Offset.Equals(default);
        }

        public bool IsNonEmpty
        {
             [MethodImpl(Inline)]
             get => !Offset.Equals(default);
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Offset);
        }

        public RelativeAddress<T> Zero
        {
             [MethodImpl(Inline)]
             get => Empty;
        }


        [MethodImpl(Inline)]
        public string Format()
            => api.format(this);

        public bool Equals(RelativeAddress<T> src)
            => Offset.Equals(src.Offset);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is RelativeAddress l && Equals(l);

        [MethodImpl(Inline)]
        public static bool operator==(RelativeAddress<T> x, RelativeAddress<T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelativeAddress<T> x, RelativeAddress<T> y)
            => !x.Equals(y);

        public static RelativeAddress<T> Empty
            => default;
    }
}