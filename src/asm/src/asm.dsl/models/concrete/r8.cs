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
    using G = R8;

    partial struct AsmDsl
    {
        /// <summary>
        /// Defines an operand that specifies an 8-bit gp register
        /// </summary>
        public struct r8 : IRegister<r8,W,T>, IAsmOperand<K,T>
        {
            public T Content {get;}

            public K Kind {get;}

            [MethodImpl(Inline)]
            public r8(T src, K kind)
            {
                Content = src;
                Kind = kind;
            }
        }

        public struct al : IRegister<al,W,T,N0>
        {
            public T Content {get;}

            [MethodImpl(Inline)]
            public al(T value)
                => Content = value;

            public K Kind => K.AL;

            public RegClass Class
                => RegClass.GP;

            [MethodImpl(Inline)]
            public static implicit operator G(al src)
                => new G(src.Content, src.Kind);
        }

        public struct cl : IRegister<cl,W,T,N1>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            [MethodImpl(Inline)]
            public cl(T value)
                => Data = value;

            public K Kind => K.CL;

            [MethodImpl(Inline)]
            public static implicit operator G(cl src)
                => new G(src.Data, src.Kind);

        }

        public struct dl : IRegister<dl,W,T,N2>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            [MethodImpl(Inline)]
            public dl(T value)
                => Data = value;

            public K Kind => K.DL;

            public RegClass Class
                => RegClass.GP;

            [MethodImpl(Inline)]
            public static implicit operator G(dl src)
                => new G(src.Data, src.Kind);
        }

        public struct bl : IRegister<bl,W,T,N3>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            [MethodImpl(Inline)]
            public static implicit operator G(bl src)
                => new G(src.Data, src.Kind);

            [MethodImpl(Inline)]
            public bl(T value)
                => Data = value;

            public K Kind => K.BL;
        }

        public struct sil : IRegister<sil,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            [MethodImpl(Inline)]
            public sil(T value)
                => Data = value;

            public K Kind => K.SIL;

            [MethodImpl(Inline)]
            public static implicit operator G(sil src)
                => new G(src.Data, src.Kind);
        }

        public struct dil : IRegister<dil,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            [MethodImpl(Inline)]
            public dil(T value)
                => Data = value;

            public K Kind => K.DIL;

            [MethodImpl(Inline)]
            public static implicit operator G(dil src)
                => new G(src.Data, src.Kind);
        }

        public struct spl : IRegister<spl,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            [MethodImpl(Inline)]
            public spl(T value)
                => Data = value;

            public K Kind => K.SPL;


            [MethodImpl(Inline)]
            public static implicit operator G(spl src)
                => new G(src.Data, src.Kind);
        }

        public struct bpl : IRegister<bpl,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            [MethodImpl(Inline)]
            public bpl(T value)
                => Data = value;

            public K Kind => K.BPL;

            [MethodImpl(Inline)]
            public static implicit operator G(bpl src)
                => new G(src.Data, src.Kind);
        }

        public struct r8b : IRegister<r8b,W,T>
        {
            public T Content {get;}


            [MethodImpl(Inline)]
            public r8b(T value)
                => Content = value;

            public K Kind => K.R8L;


            [MethodImpl(Inline)]
            public static implicit operator G(r8b src)
                => new G(src.Content, src.Kind);
        }

        public struct r9b : IRegister<r9b,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            [MethodImpl(Inline)]
            public r9b(T value)
                => Data = value;

            public K Kind => K.R9L;

            [MethodImpl(Inline)]
            public static implicit operator G(r9b src)
                => new G(src.Data, src.Kind);
        }

        public struct r10b : IRegister<r10b,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            [MethodImpl(Inline)]
            public r10b(T value)
                => Data = value;

            public K Kind => K.R10L;

            [MethodImpl(Inline)]
            public static implicit operator G(r10b src)
                => new G(src.Data, src.Kind);
        }

        public struct r11b : IRegister<r11b,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r11b(T value)
                => Data = value;

            public K Kind => K.R11L;

            public RegClass Class
                => RegClass.GP;
        }

        public struct r12b : IRegister<r12b,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r12b(T value)
                => Data = value;

            public K Kind => K.R12L;

            public RegClass Class
                => RegClass.GP;
        }

        public struct r13b : IRegister<r13b,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r13b(T value)
                => Data = value;

            public K Kind => K.R13L;

            public RegClass Class
                => RegClass.GP;
        }

        public struct r14b : IRegister<r14b,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get =>new G(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r14b(T value)
                => Data = value;

            public K Kind => K.R14L;

            public RegClass Class
                => RegClass.GP;
        }

        public struct r15b : IRegister<r15b,W,T>
        {
            public T Data;

            T IContented<T>.Content
                => Data;

            public G Generalized
            {
                [MethodImpl(Inline)]
                get => new G(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r15b(T value)
                => Data = value;

            public K Kind => K.R15L;
            public RegClass Class

                => RegClass.GP;
       }
    }
}