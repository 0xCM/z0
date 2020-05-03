//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmMemScale : INullary<AsmMemScale>
    {   
        public static AsmMemScale Empty => new AsmMemScale(MemScaleKind.None);

        public AsmMemScale Zero => Empty;
        
        public readonly MemScaleKind Kind; 

        [MethodImpl(Inline)]
        public static implicit operator AsmMemScale(int src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmMemScale(MemScaleKind src)
            => new AsmMemScale(src);

        [MethodImpl(Inline)]
        public static implicit operator MemScaleKind(AsmMemScale src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static AsmMemScale From(int value)
        {
            if(value == 1 || value == 2 || value == 4 || value == 8)
                return new AsmMemScale((MemScaleKind)value);
            else
                return new AsmMemScale(MemScaleKind.None);
        }

        [MethodImpl(Inline)]
        internal AsmMemScale(MemScaleKind kind)
        {
            this.Kind = kind;
        }

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

        public bool IsNonUnital
        {
            [MethodImpl(Inline)]
            get => Kind != MemScaleKind.S1;
        }

        public byte Value
        {
            [MethodImpl(Inline)]
            get => (byte) Kind;
        }

        public override string ToString() 
            => ((byte)Kind).ToString();
    }
}