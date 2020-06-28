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
    /// Defines an association between an integer in the range [0,0xFF] and unmanaged data of parametric type
    /// </summary>
    public readonly struct HexKindValue<T> : IHexKindValue<T>
        where T : unmanaged
    {
        readonly T value;

        public HexKind8 Kind {get;}

        public T Value
        {
            [MethodImpl(Inline)]
            get => value;
        }

        public ReadOnlySpan<byte> Data 
        {
            [MethodImpl(Inline)]
            get => Root.bytespan(value);
        }

        [MethodImpl(Inline)]
        public static implicit operator HexKindValue<T>((HexKind8 k, T value) src)
            => new HexKindValue<T>(src.k, src.value);

        [MethodImpl(Inline)]
        public static implicit operator HexKindValue<T>((byte k, T value) src)
            => new HexKindValue<T>((HexKind8)src.k, src.value);

        [MethodImpl(Inline)]
        public static implicit operator HexKindValue<T>((int k, T value) src)
            => new HexKindValue<T>((HexKind8)src.k, src.value);

        [MethodImpl(Inline)]
        public HexKindValue(HexKind8 code, T value)
        {
            this.Kind = code;
            this.value = value;
        }
    }
}