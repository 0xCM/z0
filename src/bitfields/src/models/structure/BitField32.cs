//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;

    using static Konst;

    /// <summary>
    /// Defines a minimalistic 32-bit bitfield
    /// </summary>
    public readonly ref struct BitField32
    {
        public const byte BitCount = 32;

        readonly Span<uint1> Data;

        [MethodImpl(Inline)]
        public static BitField32 Init(byte[] data)
            => new BitField32(data);

        [MethodImpl(Inline)]
        public static BitField32 create()
            => new BitField32(sys.alloc<uint1>(BitCount));

        [MethodImpl(Inline)]
        public static BitField32<E> create<E>()
            where E : unmanaged, Enum
                => new BitField32<E>(create());

        [MethodImpl(Inline)]
        public static BitField32<E> init<E>(byte[] data)
            where E : unmanaged, Enum
                => new BitField32<E>(Init(data));

        [MethodImpl(Inline)]
        public BitField32(Span<uint1> data)
            => Data = data;

        [MethodImpl(Inline)]
        public BitField32(Span<byte> data)
            => Data = z.recover<byte,uint1>(data);

        [MethodImpl(Inline)]
        ref uint1 Bit(uint5 index)
            => ref z.seek(Data, index);

        public uint1 this[uint5 index]
        {
            [MethodImpl(Inline)]
            get => Bit(index) == 1;

            [MethodImpl(Inline)]
            set => Bit(index) = (byte)value;
        }

        [MethodImpl(Inline)]
        public string Format()
        {
            Span<char> dst = stackalloc char[BitCount];
            for(var i=0u; i<BitCount; i++)
                z.seek(dst,i) = z.skip(Data,i).ToChar();
            return new string(dst);
        }
    }

    /// <summary>
    /// Defines an extremely lo-tech 32-bit bitfield, as in the non-parametric version,
    /// but field content is indexed by an enumeration
    /// </summary>
    public readonly ref struct BitField32<E>
        where E : unmanaged, Enum
    {
        readonly BitField32 Data;

        [MethodImpl(Inline)]
        internal BitField32(in BitField32 data)
            => Data = data;

        [MethodImpl(Inline)]
        public uint5 FieldIndex(E id)
            => (uint5)BitOperations.Log2(Root.e32u(id));

        public uint1 this[E id]
        {
            [MethodImpl(Inline)]
            get => Data[FieldIndex(id)];
            [MethodImpl(Inline)]
            set => Data[FieldIndex(id)] = value;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Data.Format();
    }
}