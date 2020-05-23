//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a sequence of umanaged values indexed by an integer in the range [0,255]
    /// </summary>
    public readonly struct HexIndex<T> : IHexIndex<T>
        where T : unmanaged
    {
        readonly T[] Index;

        [MethodImpl(Inline)]
        public static HexIndex<T> Define(params HexKindValue<T>[] src)
            => Symbolic.index(src);

        [MethodImpl(Inline)]
        internal HexIndex(T[] index)
        {
            this.Index = index;
        }

        [MethodImpl(Inline)]
        public ref readonly T Lookup(HexKind key)
            => ref Index[(int)key];

        public ref readonly T this[HexKind index]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(index);
        }
    }
}