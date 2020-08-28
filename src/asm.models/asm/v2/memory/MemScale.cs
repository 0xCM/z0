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
    public readonly struct MemScale : ILiteralCover<MemScale>
    {   
        public MemScaleKind Kind {get;}

        public static MemScale Empty 
            => new MemScale(MemScaleKind.None);
                
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

        public MemScale Zero 
            => Empty;

        [MethodImpl(Inline)]
        public static implicit operator MemScale(int src)
            => From(src);

        [MethodImpl(Inline)]
        public static implicit operator MemScale(MemScaleKind src)
            => new MemScale(src);

        [MethodImpl(Inline)]
        public static implicit operator MemScaleKind(MemScale src)
            => src.Kind;

        [MethodImpl(Inline)]
        public static MemScale From(int value)
        {
            if(value == 1 || value == 2 || value == 4 || value == 8)
                return new MemScale((MemScaleKind)value);
            else
                return new MemScale(MemScaleKind.None);
        }

        [MethodImpl(Inline)]
        internal MemScale(MemScaleKind kind)
        {
            Kind = kind;
        }

        public override string ToString() 
            => ((byte)Kind).ToString();
    }
}