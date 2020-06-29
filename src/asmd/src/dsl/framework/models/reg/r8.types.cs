//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Dsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = RegisterKind;
        
    public readonly struct al : IRegOp8<al,N0>
    {            
        public byte Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r8(al src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public al(byte value)
        {
            Content = value;
        }

        public K Kind => K.AL;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }

    public readonly struct cl : IRegOp8<cl,N1>
    {        
        public byte Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r8(cl src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public cl(byte value)
        {
            Content = value;
        }

        public K Kind => K.CL;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }    

    public readonly struct dl : IRegOp8<dl,N2>
    {            
        public byte Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r8(dl src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public dl(byte value)
        {
            Content = value;
        }

        public K Kind => K.DL;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }    

    public readonly struct bl : IRegOp8<bl,N3>
    {        
        public byte Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r8(bl src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public bl(byte value)
        {
            Content = value;
        }

        public K Kind => K.BL;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }    

    public readonly struct sil : IRegOp8<sil,N4>
    {            
        public byte Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r8(sil src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public sil(byte value)
        {
            Content = value;
        }

        public K Kind => K.SIL;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }    

    public readonly struct dil : IRegOp8<dil,N5>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r8(dil src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public dil(byte value)
        {
            Content = value;
        }

        public K Kind => K.DIL;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }        

    public readonly struct spl : IRegOp8<spl,N6>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r8(spl src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public spl(byte value)
        {
            Content = value;
        }

        public K Kind => K.SPL;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }            

    public readonly struct bpl : IRegOp8<bpl,N7>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r8(bpl src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public bpl(byte value)
        {
            Content = value;
        }

        public K Kind => K.BPL;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }                

    public readonly struct r8b : IRegOp8<r8b,N8>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator r8(r8b src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r8b(byte value)
        {
            Content = value;
        }

        public K Kind => K.R8L;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }                    

    public readonly struct r9b : IRegOp8<r9b,N9>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public r9b(byte value)
        {
            Content = value;
        }

        public K Kind => K.R9L;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }                        

    public readonly struct r10b : IRegOp8<r10b,N10>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public r10b(byte value)
        {
            Content = value;
        }

        public K Kind => K.R10L;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }                        

    public readonly struct r11b : IRegOp8<r11b,N11>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public r11b(byte value)
        {
            Content = value;
        }

        public K Kind => K.R11L;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }                        

    public readonly struct r12b : IRegOp8<r12b,N12>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public r12b(byte value)
        {
            Content = value;
        }

        public K Kind => K.R12L;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }                    

    public readonly struct r13b : IRegOp8<r13b,N13>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public r13b(byte value)
        {
            Content = value;
        }

        public K Kind => K.R13L;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }                        

    public readonly struct r14b : IRegOp8<r14b,N14>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public r14b(byte value)
        {
            Content = value;
        }

        public K Kind => K.R14L;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }                        

    public readonly struct r15b : IRegOp8<r15b,N15>
    {
        public byte Content {get;}

        [MethodImpl(Inline)]
        public r15b(byte value)
        {
            Content = value;
        }

        public K Kind => K.R15L;

        public r8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r8(Content, Kind);
        }
    }
}