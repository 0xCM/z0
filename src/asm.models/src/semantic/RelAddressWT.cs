//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RelativeAddress<BW,RW,B,R>
        where BW: unmanaged, INumericWidth
        where RW: unmanaged, INumericWidth
        where B: unmanaged
        where R: unmanaged
    {
        public readonly B Base;

        public readonly R Offset;

        NumericWidth BaseWidth
        {
            [MethodImpl(Inline)]
            get => Widths.numeric<BW>();
        }

        NumericWidth RelativeWidth
        {
            [MethodImpl(Inline)]
            get => Widths.numeric<RW>();
        }

        public bool IsEmpty
        {
             [MethodImpl(Inline)]
             get => Offset.Equals(default);
        }

        public uint Hash
        {
            [MethodImpl(Inline)]
            get => z.hash(Offset);
        }

        public bool IsNonEmpty
        {
             [MethodImpl(Inline)]
             get => !Offset.Equals(default);
        }

        public RelativeAddress<BW,RW,B,R> Zero
            => default;

        [MethodImpl(Inline)]
        public static bool operator==(RelativeAddress<BW,RW,B,R> x, RelativeAddress<BW,RW,B,R> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelativeAddress<BW,RW,B,R> x, RelativeAddress<BW,RW,B,R> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public RelativeAddress(B @base, R offset)
        {
            Base = @base;
            Offset = offset;
        }

        public static RelativeAddress<BW,RW,B,R> Empty
            => default;

        [MethodImpl(Inline)]
        public string Format()
            => Hex.format<RW,R>(Offset);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public bool Equals(RelativeAddress<BW,RW,B,R> src)
            => Offset.Equals(src.Offset);

        public override bool Equals(object src)
            => src is RelativeAddress x && Equals(x);

        public override int GetHashCode()
            => (int)Hash;
    }
}