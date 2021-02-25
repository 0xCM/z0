//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Sequential
    {
        public struct Seq16x2 : IDataTypeComparable<Seq16x2>
        {
            public ushort Lo;

            public ushort Hi;

            [MethodImpl(Inline)]
            public Seq16x2(ushort lo, ushort hi)
            {
                Lo = lo;
                Hi = hi;
            }

            public uint Joined
            {
                [MethodImpl(Inline)]
                get => (uint)Lo | ((uint)Hi << 16);
            }

            [MethodImpl(Inline)]
            public bool Equals(Seq16x2 src)
                => Joined == src.Joined;

            [MethodImpl(Inline)]
            public int CompareTo(Seq16x2 src)
                => Joined.CompareTo(src.Joined);


            public void IncLo()
            {
                Lo++;
            }

            public void IncHi()
            {
                Hi++;
            }

            public void DecLo()
            {
                Lo--;
            }

            public void DecHi()
            {
                Hi--;
            }

            public string Format()
                => Joined.FormatHex();

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static Seq16x2 operator ++(Seq16x2 src)
            {
                src.IncLo();
                return src;
            }

            [MethodImpl(Inline)]
            public static Seq16x2 operator --(Seq16x2 src)
            {
                src.DecLo();
                return src;
            }

            [MethodImpl(Inline)]
            public static implicit operator Seq16x2((ushort lo, ushort hi) src)
                => new Seq16x2(src.lo,src.hi);
        }
    }
}