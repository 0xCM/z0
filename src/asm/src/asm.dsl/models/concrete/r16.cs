//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmDsl;

    using K = RegisterKind;
    using W = W16;
    using T = System.UInt16;
    using G = R16;

    partial struct AsmDsl
    {
        /// <summary>
        /// Defines an operand that specifies a 16-bit gp register
        /// </summary>
        public struct r16 : IRegister<r16,W,T>, IAsmOperand<K,T>
        {
            public T Content {get;}

            public K Kind {get;}

            [MethodImpl(Inline)]
            public r16(T src, K kind)
            {
                Content = src;
                Kind = kind;
            }
        }

        public struct ax : IRegister<ax,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(ax src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public ax(T value)
            {
                Content = value;
            }

            public K Kind => K.AX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, Kind);
            }
        }

        public struct cx : IRegister<cx,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(cx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public cx(T value)
            {
                Content = value;
            }

            public K Kind => K.CX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct dx : IRegister<dx,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public dx(T value)
            {
                Content = value;
            }

            public K Kind => K.DX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator G(dx src)
                => src.Generalized;
        }

        public struct bx : IRegister<bx,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(bx src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public bx(T value)
            {
                Content = value;
            }

            public K Kind => K.BX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct si : IRegister<si,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(si src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public si(T value)
            {
                Content = value;
            }

            public K Kind => K.SI;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }

        }

        public struct di : IRegister<di,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(di src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public di(T value)
            {
                Content = value;
            }

            public K Kind => K.DI;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct sp : IRegister<sp,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public sp(T value)
            {
                Content = value;
            }

            public K Kind => K.SP;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator G(sp src)
                => src.Generalized;
        }

        public struct bp : IRegister<bp,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(bp src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public bp(T value)
            {
                Content = value;
            }

            public K Kind => K.AX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r8w : IRegister<r8w,W,T>
        {
            public T Content  {get;}


            [MethodImpl(Inline)]
            public static implicit operator G(r8w src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public r8w(T value)
            {
                Content = value;
            }

            public K Kind => K.R8W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r9w : IRegister<r9w,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(r9w src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public r9w(T value)
            {
                Content = value;
            }

            public K Kind => K.R9W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r10w : IRegister<r10w,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(r10w src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public r10w(T value)
            {
                Content = value;
            }

            public K Kind => K.R10W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r11w : IRegister<r11w,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(r11w src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public r11w(T value)
            {
                Content = value;
            }

            public K Kind => K.R11W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r12w : IRegister<r12w,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(r12w src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public r12w(T value)
            {
                Content = value;
            }

            public K Kind => K.R12W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r13w : IRegister<r13w,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(r13w src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public r13w(T value)
            {
                Content = value;
            }

            public K Kind => K.R13W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r14w : IRegister<r14w,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(r14w src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public r14w(T value)
            {
                Content = value;
            }

            public K Kind => K.R14W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
        }

        public struct r15w : IRegister<r15w,W,T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(r15w src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public r15w(T value)
            {
                Content = value;
            }

            public K Kind => K.R15W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, Kind);
            }
       }
    }
}