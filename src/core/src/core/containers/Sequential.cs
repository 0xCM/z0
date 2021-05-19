//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    [ApiHost]
    public readonly struct Sequential
    {
       const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static Seq16x2 create(ushort lo, ushort hi)
            => new Seq16x2(lo, hi);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref Sequential<T> next<T>(in Sequential<T> src)
            where T : unmanaged
        {
            ref var dst = ref @edit(src);
            ref var value = ref dst.Lo;

            if(size<T>() == 1)
                uint8(ref value) = (byte)(uint8(value) + 1);
            else if(size<T>() == 2)
                uint16(ref value) = (ushort)(uint16(value) + 1);
            else if(size<T>() == 4)
                uint32(ref value) = uint32(value) + 1u;
            else if(size<T>() == 8)
                uint64(ref value) = uint64(value) + 1ul;
            else
                throw no<T>();

            return ref dst;
        }


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