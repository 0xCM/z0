//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = RegisterKind;

    partial struct XRegisters
    {
        public struct ax : IRegister<ax,W16,ushort>
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
                get => new R16(Content, Kind);
            }
        }

        public struct cx : IRegister<cx,W16,ushort>
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

        public struct dx : IRegister<dx,W16,ushort>
        {
            public ushort Content  {get;}

            [MethodImpl(Inline)]
            public dx(ushort value)
            {
                Content = value;
            }

            public K Kind => K.DX;

            public R16 Generalized
            {
                [MethodImpl(Inline)]
                get => new R16(Content, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator R16(dx src)
                => src.Generalized;
        }

        public struct bx : IRegister<bx,W16,ushort>
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

        public struct si : IRegister<si,W16,ushort>
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

        public struct di : IRegister<di,W16,ushort>
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

        public struct sp : IRegister<sp,W16,ushort>
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

        public struct bp : IRegister<bp,W16,ushort>
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

        public struct r8w : IRegister<r8w,W16,ushort>
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

        public struct r9w : IRegister<r9w,W16,ushort>
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

        public struct r10w : IRegister<r10w,W16,ushort>
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

        public struct r11w : IRegister<r11w,W16,ushort>
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

        public struct r12w : IRegister<r12w,W16,ushort>
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

        public struct r13w : IRegister<r13w,W16,ushort>
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

        public struct r14w : IRegister<r14w,W16,ushort>
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

        public struct r15w : IRegister<r15w,W16,ushort>
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
}