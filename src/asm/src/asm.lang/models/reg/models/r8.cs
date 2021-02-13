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
    using W = W8;
    using T = System.Byte;
    using G = AsmRegs.r8;

    partial struct AsmRegs
    {
        public struct R8<R> : IRegister<R8<R>,W8,byte>, IRegOp8<byte>
            where R : unmanaged, IRegOp8
        {
            public byte Data;

            [MethodImpl(Inline)]
            public R8(byte src)
                => Data = src;

            public byte Content
            {
                [MethodImpl(Inline)]
                get => Data;
            }

            public RegisterKind RegKind
            {
                [MethodImpl(Inline)]
                get => default(R).RegKind;
            }

            public RegIndex Index
            {
                [MethodImpl(Inline)]
                get => Registers.code(RegKind);
            }

            [MethodImpl(Inline)]
            public static implicit operator r8(R8<R> src)
                => new r8(src.Content, src.RegKind);
        }

        /// <summary>
        /// Defines an operand that specifies an 8-bit gp register
        /// </summary>
        public struct r8 : IRegister<r8,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            public K RegKind {get;}

            [MethodImpl(Inline)]
            public r8(T src, K kind)
            {
                Content = src;
                RegKind = kind;
            }
        }

        public struct al : IRegister<al,W,T,N0>, IRegOp8<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public al(T value)
                => Content = value;

            public K RegKind => K.AL;

            [MethodImpl(Inline)]
            public static implicit operator G(al src)
                => new G(src.Content, src.RegKind);
        }

        public struct cl : IRegister<cl,W,T,N1>, IRegOp8<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public cl(T value)
                => Content = value;

            public K RegKind => K.CL;

            [MethodImpl(Inline)]
            public static implicit operator G(cl src)
                => new G(src.Content, src.RegKind);

        }

        public struct dl : IRegister<dl,W,T,N2>, IRegOp8<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public dl(T value)
                => Content = value;

            public K RegKind => K.DL;


            [MethodImpl(Inline)]
            public static implicit operator G(dl src)
                => new G(src.Content, src.RegKind);
        }

        public struct bl : IRegister<bl,W,T,N3>, IRegOp8<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public static implicit operator G(bl src)
                => new G(src.Content, src.RegKind);

            [MethodImpl(Inline)]
            public bl(T value)
                => Content = value;

            public K RegKind => K.BL;
        }

        public struct sil : IRegister<sil,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public sil(T value)
                => Content = value;

            public K RegKind => K.SIL;

            [MethodImpl(Inline)]
            public static implicit operator G(sil src)
                => new G(src.Content, src.RegKind);
        }

        public struct dil : IRegister<dil,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public dil(T value)
                => Content = value;

            public K RegKind => K.DIL;

            [MethodImpl(Inline)]
            public static implicit operator G(dil src)
                => new G(src.Content, src.RegKind);
        }

        public struct spl : IRegister<spl,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public spl(T value)
                => Content = value;

            public K RegKind => K.SPL;


            [MethodImpl(Inline)]
            public static implicit operator G(spl src)
                => new G(src.Content, src.RegKind);
        }

        public struct bpl : IRegister<bpl,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public bpl(T value)
                => Content = value;

            public K RegKind => K.BPL;

            [MethodImpl(Inline)]
            public static implicit operator G(bpl src)
                => new G(src.Content, src.RegKind);
        }

        public struct r8b : IRegister<r8b,W,T>, IRegOp8<T>
        {
            public T Content {get;}


            [MethodImpl(Inline)]
            public r8b(T value)
                => Content = value;

            public K RegKind => K.R8L;


            [MethodImpl(Inline)]
            public static implicit operator G(r8b src)
                => new G(src.Content, src.RegKind);
        }

        public struct r9b : IRegister<r9b,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r9b(T value)
                => Content = value;

            public K RegKind => K.R9L;

            [MethodImpl(Inline)]
            public static implicit operator G(r9b src)
                => new G(src.Content, src.RegKind);
        }

        public struct r10b : IRegister<r10b,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public r10b(T value)
                => Content = value;

            public K RegKind => K.R10L;

            [MethodImpl(Inline)]
            public static implicit operator G(r10b src)
                => new G(src.Content, src.RegKind);
        }

        public struct r11b : IRegister<r11b,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public r11b(T value)
                => Content = value;

            public K RegKind => K.R11L;

        }

        public struct r12b : IRegister<r12b,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public r12b(T value)
                => Content = value;

            public K RegKind => K.R12L;

        }

        public struct r13b : IRegister<r13b,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public r13b(T value)
                => Content = value;

            public K RegKind => K.R13L;


        }

        public struct r14b : IRegister<r14b,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public r14b(T value)
                => Content = value;

            public K RegKind => K.R14L;

        }

        public struct r15b : IRegister<r15b,W,T>, IRegOp8<T>
        {
            public T Content {get;}

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Content, RegKind);
            }

            [MethodImpl(Inline)]
            public r15b(T value)
                => Content = value;

            public K RegKind => K.R15L;
       }
    }
}