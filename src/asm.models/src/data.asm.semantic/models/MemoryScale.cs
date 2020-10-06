//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [LiteralCover]
    public readonly struct MemoryScale
    {
        public MemorScaleKind Kind {get;}

        public static MemoryScale Empty
            => new MemoryScale(MemorScaleKind.None);

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Kind == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Kind != 0;
        }

        public bool NonUnital
        {
             [MethodImpl(Inline)]
             get => Kind != MemorScaleKind.S1;
        }

        public bool NonZero
        {
            [MethodImpl(Inline)]
            get =>  Kind != 0;
        }

        public byte Value
        {
            [MethodImpl(Inline)]
            get => (byte) Kind;
        }

        public MemoryScale Zero
            => Empty;

        [MethodImpl(Inline)]
        public static implicit operator MemoryScale(int src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator MemoryScale(MemorScaleKind src)
            => new MemoryScale(src);

        [MethodImpl(Inline)]
        public static implicit operator MemorScaleKind(MemoryScale src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static MemoryScale From(int value)
        {
            if(value == 1 || value == 2 || value == 4 || value == 8)
                return new MemoryScale((MemorScaleKind)value);
            else
                return new MemoryScale(MemorScaleKind.None);
        }

        [MethodImpl(Inline)]
        internal MemoryScale(MemorScaleKind kind)
        {
            Kind = kind;
        }

        public override string ToString()
            => ((byte)Kind).ToString();
    }
}