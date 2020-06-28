//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines a sequence of umanaged values indexed by an integer in the range [0,255]
    /// </summary>
    public readonly struct HexIndex<T> : IHexIndex<T>
        where T : unmanaged
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public HexIndex(T[] src)
        {
            Data = src;
        }

        [MethodImpl(Inline)]
        public ref readonly T Lookup(HexKind8 key)
            => ref Data[(int)key];

        public ref readonly T this[HexKind8 index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref readonly T this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup((HexKind8)index);
        }
    }
}