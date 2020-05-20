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
            => new HexIndex<T>(src);        

        [MethodImpl(Inline)]
        internal HexIndex(Func<T,HexKind> f, T[] src)
        {
            Index = new T[256];
            for(var i=0; i<src.Length; i++)
                Index[(int)f(src[i])] = src[i];
        }

        [MethodImpl(Inline)]
        HexIndex(HexKindValue<T>[] src)
        {
            Index = new T[256];
            for(var i=0; i<src.Length; i++)
                Index[(int)src[i].Kind] = src[i].Value;
        }

        public ref readonly T Lookup(HexKind key)
            => ref Index[(int)key];

        public ref readonly T this[HexKind index]
        {
            [MethodImpl(Inline)]
            get => ref Index[(int)index];
        }
    }
}