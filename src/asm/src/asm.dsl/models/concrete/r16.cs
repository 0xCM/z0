//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using K = RegisterKind;
    using W = W16;
    using T = System.UInt16;
    using G = R16;

    partial struct AsmDsl
    {
        /// <summary>
        /// Defines an operand that specifies a 16-bit gp register
        /// </summary>
        public struct r16 : IRegister<r16,W,T>, IRegOp<T>
        {
            public T Content {get;}

            public K RegKind {get;}

            [MethodImpl(Inline)]
            public r16(T src, K kind)
            {
                Content = src;
                RegKind = kind;
            }
        }

        public struct ax : IRegister<ax,W,T>, IRegOp<T>
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

            public K RegKind => K.AX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, RegKind);
            }
        }

        public struct cx : IRegister<cx,W,T>, IRegOp<T>
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

            public K RegKind => K.CX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct dx : IRegister<dx,W,T>, IRegOp<T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public dx(T value)
            {
                Content = value;
            }

            public K RegKind => K.DX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public static implicit operator G(dx src)
                => src.Generalized;
        }

        public struct bx : IRegister<bx,W,T>, IRegOp<T>
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

            public K RegKind => K.BX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct si : IRegister<si,W,T>, IRegOp<T>
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

            public K RegKind => K.SI;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }

        }

        public struct di : IRegister<di,W,T>, IRegOp<T>
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

            public K RegKind => K.DI;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct sp : IRegister<sp,W,T>, IRegOp<T>
        {
            public T Content  {get;}

            [MethodImpl(Inline)]
            public sp(T value)
            {
                Content = value;
            }

            public K RegKind => K.SP;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public static implicit operator G(sp src)
                => src.Generalized;
        }

        public struct bp : IRegister<bp,W,T>, IRegOp<T>
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

            public K RegKind => K.AX;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r8w : IRegister<r8w,W,T>, IRegOp<T>
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

            public K RegKind => K.R8W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r9w : IRegister<r9w,W,T>, IRegOp<T>
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

            public K RegKind => K.R9W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r10w : IRegister<r10w,W,T>, IRegOp<T>
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

            public K RegKind => K.R10W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r11w : IRegister<r11w,W,T>, IRegOp<T>
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

            public K RegKind => K.R11W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r12w : IRegister<r12w,W,T>, IRegOp<T>
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

            public K RegKind => K.R12W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r13w : IRegister<r13w,W,T>, IRegOp<T>
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

            public K RegKind => K.R13W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r14w : IRegister<r14w,W,T>, IRegOp<T>
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

            public K RegKind => K.R14W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
        }

        public struct r15w : IRegister<r15w,W,T>, IRegOp<T>
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

            public K RegKind => K.R15W;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }
       }
    }
}