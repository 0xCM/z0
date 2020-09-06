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
    using static z;

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