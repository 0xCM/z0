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
    /// Defines a T-parametric 32-bit bitfields
    /// </summary>
    public readonly ref struct BitField32<T>
        where T : unmanaged
    {
        readonly BitField32 Data;

        [MethodImpl(Inline)]
        internal BitField32(BitField32 data)
            => Data = data;

        [MethodImpl(Inline)]
        public uint5 FieldIndex(T id)
            => (uint5)BitOperations.Log2(uint32(id));

        public uint1 this[T id]
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