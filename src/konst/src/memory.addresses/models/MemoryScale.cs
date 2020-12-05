//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum MemoryScaleKind : byte
    {
        None  = 0,

        S1 = 1,

        S2 = 2,

        S4 = 4,

        S8 = 8
    }

    [LiteralCover]
    public readonly struct MemoryScale
    {
        public MemoryScaleKind Kind {get;}

        [MethodImpl(Inline)]
        public MemoryAddress Apply(MemoryAddress src)
            =>(ulong)Kind * src;

        public static MemoryScale Empty
            => new MemoryScale(MemoryScaleKind.None);

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
             get => Kind != MemoryScaleKind.S1;
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
        public static implicit operator MemoryScale(MemoryScaleKind src)
            => new MemoryScale(src);

        [MethodImpl(Inline)]
        public static implicit operator MemoryScaleKind(MemoryScale src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static MemoryScale From(int value)
        {
            if(value == 1 || value == 2 || value == 4 || value == 8)
                return new MemoryScale((MemoryScaleKind)value);
            else
                return new MemoryScale(MemoryScaleKind.None);
        }

        [MethodImpl(Inline)]
        internal MemoryScale(MemoryScaleKind kind)
        {
            Kind = kind;
        }

        public override string ToString()
            => ((byte)Kind).ToString();
    }
}