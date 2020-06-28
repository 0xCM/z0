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
    public readonly struct BitField32
    {        
        const int BitCount = 32;

        readonly byte[] Data;

        [MethodImpl(Inline)]
        public static BitField32 Init(byte[] data)
            => new BitField32(data);

        [MethodImpl(Inline)]
        public static BitField32 Alloc()
            => new BitField32(sys.alloc<byte>(BitCount));

        [MethodImpl(Inline)]
        public static BitField32<E> alloc<E>()
            where E : unmanaged, Enum
                => new BitField32<E>(Alloc());

        [MethodImpl(Inline)]
        public static BitField32<E> init<E>(byte[] data)
            where E : unmanaged, Enum
                => new BitField32<E>(Init(data));

        [MethodImpl(Inline)]
        public BitField32(byte[] data)
            => Data = data;

        [MethodImpl(Inline)]
        ref byte Bit(int index)
            => ref Data[index];

        public bit this[int index]
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
            for(var i=0; i<BitCount; i++)
                Root.seek(dst,i) = this[i].ToChar();
            return new string(dst);
        }
    }
    
    /// <summary>
    /// Defines an extremely lo-tech 32-bit bitfield, as in the non-parametric version,
    /// but field content is indexed by an enumeration
    /// </summary>
    public readonly struct BitField32<E>
        where E : unmanaged, Enum
    {
        readonly BitField32 Data;

        [MethodImpl(Inline)]
        internal BitField32(in BitField32 data)
            => Data = data;

        [MethodImpl(Inline)]
        public int FieldIndex(E id)
            => (int)BitOperations.Log2(Root.e32u(id));

        public bit this[E id]
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