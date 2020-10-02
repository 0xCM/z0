//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericCast;

    public readonly struct RelativeAddress<T> : INullary<RelativeAddress<T>>, ITextual, INullity
        where T : unmanaged
    {
        readonly T Offset;

        NumericWidth Size
        {
            [MethodImpl(Inline)]
            get => (NumericWidth)z.bitwidth<T>();
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
        public static RelativeAddress<T> From(T offset)
            => new RelativeAddress<T>(offset);

        [MethodImpl(Inline)]
        public static bool operator==(RelativeAddress<T> x, RelativeAddress<T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelativeAddress<T> x, RelativeAddress<T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal RelativeAddress(T offset)
            => Offset = offset;

        [MethodImpl(Inline)]
        public string Format()
        {
            switch(Size)
            {
                case NumericWidth.W8:
                    return force<T,byte>(Offset).FormatAsmHex();
                case NumericWidth.W16:
                    return force<T,ushort>(Offset).FormatAsmHex();
                default:
                    return force<T,uint>(Offset).FormatAsmHex();
            }
        }

        public bool Equals(RelativeAddress<T> src)
            => Offset.Equals(src.Offset);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is RelativeAddress l && Equals(l);

        public static RelativeAddress<T> Empty
            => default;
    }
}