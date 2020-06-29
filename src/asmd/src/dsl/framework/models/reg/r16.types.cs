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

    public readonly struct ax : IRegOp16<ax,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(ax src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public ax(ushort value)
        {
            Content = value;
        }

        public K Kind => K.AX;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }

    public readonly struct cx : IRegOp16<cx,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(cx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public cx(ushort value)
        {
            Content = value;
        }

        public K Kind => K.CX;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }    

    public readonly struct dx : IRegOp16<dx,ushort>
    {        
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(dx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public dx(ushort value)
        {
            Content = value;
        }

        public K Kind => K.DX;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }

    }    

    public readonly struct bx : IRegOp16<bx,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(bx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public bx(ushort value)
        {
            Content = value;
        }
        
        public K Kind => K.BX;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }    

    public readonly struct si : IRegOp16<si,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(si src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public si(ushort value)
        {
            Content = value;
        }

        public K Kind => K.SI;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }

    }    

    public readonly struct di : IRegOp16<di,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(di src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public di(ushort value)
        {
            Content = value;
        }

        public K Kind => K.DI;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }        

    public readonly struct sp : IRegOp16<sp,ushort>
    {            
        public ushort Content  {get;}


        [MethodImpl(Inline)]
        public static implicit operator r16(sp src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public sp(ushort value)
        {
            Content = value;
        }

        public K Kind => K.SP;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }            

    public readonly struct bp : IRegOp16<bp,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(bp src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public bp(ushort value)
        {
            Content = value;
        }

        public K Kind => K.AX;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }                

    public readonly struct r8w : IRegOp16<r8w,ushort>
    {
        public ushort Content  {get;}


        [MethodImpl(Inline)]
        public static implicit operator r16(r8w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r8w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R8W;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }                    

    public readonly struct r9w : IRegOp16<r9w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(r9w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r9w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R9W;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }                        

    public readonly struct r10w : IRegOp16<r10w,ushort>
    {        
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(r10w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r10w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R10W;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }                        

    public readonly struct r11w : IRegOp16<r11w,ushort>
    {            
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(r11w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r11w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R11W;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }                        

    public readonly struct r12w : IRegOp16<r12w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(r12w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r12w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R12W;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }                    

    public readonly struct r13w : IRegOp16<r13w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(r13w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r13w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R13W;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }                        

    public readonly struct r14w : IRegOp16<r14w,ushort>
    {            
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(r14w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r14w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R14W;

        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
    }                        

    public readonly struct r15w : IRegOp16<r15w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator r16(r15w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r15w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R15W;
 
        public r16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new r16(Content, Kind);
        }
   }
}