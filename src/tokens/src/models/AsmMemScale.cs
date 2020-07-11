//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmMemScale : INullary<AsmMemScale>, INullity
    {   
        public MemScaleKind Kind {get;}

        public static AsmMemScale Empty 
            => new AsmMemScale(MemScaleKind.None);
        
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
             get => Kind != MemScaleKind.S1;
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

        public AsmMemScale Zero 
            => Empty;

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
            Kind = kind;
        }

        public override string ToString() 
            => ((byte)Kind).ToString();
    }
}