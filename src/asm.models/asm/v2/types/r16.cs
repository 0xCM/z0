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

    public readonly struct ax : IRegOperand<ax,W16,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(ax src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public ax(ushort value)
        {
            Content = value;
        }

        public K Kind => K.AX;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct cx : IRegOperand<cx,W16,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(cx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public cx(ushort value)
        {
            Content = value;
        }

        public K Kind => K.CX;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct dx : IRegOperand<dx,W16,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(dx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public dx(ushort value)
        {
            Content = value;
        }

        public K Kind => K.DX;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }

    }

    public readonly struct bx : IRegOperand<bx,W16,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(bx src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public bx(ushort value)
        {
            Content = value;
        }

        public K Kind => K.BX;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct si : IRegOperand<si,W16,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(si src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public si(ushort value)
        {
            Content = value;
        }

        public K Kind => K.SI;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }

    }

    public readonly struct di : IRegOperand<di,W16,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(di src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public di(ushort value)
        {
            Content = value;
        }

        public K Kind => K.DI;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct sp : IRegOperand16<sp,ushort>
    {
        public ushort Content  {get;}


        [MethodImpl(Inline)]
        public static implicit operator R16(sp src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public sp(ushort value)
        {
            Content = value;
        }

        public K Kind => K.SP;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct bp : IRegOperand16<bp,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(bp src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public bp(ushort value)
        {
            Content = value;
        }

        public K Kind => K.AX;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct r8w : IRegOperand16<r8w,ushort>
    {
        public ushort Content  {get;}


        [MethodImpl(Inline)]
        public static implicit operator R16(r8w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r8w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R8W;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct r9w : IRegOperand16<r9w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(r9w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r9w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R9W;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct r10w : IRegOperand16<r10w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(r10w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r10w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R10W;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct r11w : IRegOperand16<r11w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(r11w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r11w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R11W;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct r12w : IRegOperand16<r12w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(r12w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r12w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R12W;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct r13w : IRegOperand16<r13w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(r13w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r13w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R13W;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct r14w : IRegOperand16<r14w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(r14w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r14w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R14W;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
    }

    public readonly struct r15w : IRegOperand16<r15w,ushort>
    {
        public ushort Content  {get;}

        [MethodImpl(Inline)]
        public static implicit operator R16(r15w src)
            => src.Generalized;

        [MethodImpl(Inline)]
        public r15w(ushort value)
        {
            Content = value;
        }

        public K Kind => K.R15W;

        public R16 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R16(Content, Kind);
        }
   }
}