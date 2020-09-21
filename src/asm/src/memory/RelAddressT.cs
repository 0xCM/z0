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

    public readonly struct RelAddress<T> : INullary<RelAddress<T>>, ITextual, INullity
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

        public RelAddress<T> Zero
        {
             [MethodImpl(Inline)]
             get => Empty;
        }

        [MethodImpl(Inline)]
        public static RelAddress<T> From(T offset)
            => new RelAddress<T>(offset);

        [MethodImpl(Inline)]
        public static bool operator==(RelAddress<T> x, RelAddress<T> y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator!=(RelAddress<T> x, RelAddress<T> y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        internal RelAddress(T offset)
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

        public bool Equals(RelAddress<T> src)
            => Offset.Equals(src.Offset);

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => (int)Hash;

        public override bool Equals(object src)
            => src is RelAddress l && Equals(l);

        public static RelAddress<T> Empty
            => default;
    }
}