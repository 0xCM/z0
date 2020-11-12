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

    partial struct X86Registers
    {
        public struct al : IRegister<al,W8,byte,N0>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public al(byte value)
                => Data = value;

            public K Kind
                => K.AL;

            public RegisterClass Class
                => RegisterClass.GP;

            [MethodImpl(Inline)]
            public static implicit operator R8(al src)
                => new R8(src.Data, src.Kind);
        }

        public struct cl : IRegister<cl,W8,byte,N1>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public cl(byte value)
                => Data = value;

            public K Kind => K.CL;

            public RegisterClass Class
                => RegisterClass.GP;

            [MethodImpl(Inline)]
            public static implicit operator R8(cl src)
                => new R8(src.Data, src.Kind);

        }

        public struct dl : IRegister<dl,W8,byte,N2>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public dl(byte value)
                => Data = value;

            public K Kind => K.DL;

            public RegisterClass Class
                => RegisterClass.GP;

            [MethodImpl(Inline)]
            public static implicit operator R8(dl src)
                => new R8(src.Data, src.Kind);
        }

        public struct bl : IRegister<bl,W8,byte,N3>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public static implicit operator R8(bl src)
                => new R8(src.Data, src.Kind);

            [MethodImpl(Inline)]
            public bl(byte value)
                => Data = value;

            public K Kind => K.BL;

            public RegisterClass Class
                => RegisterClass.GP;
        }

        public struct sil : IRegister<sil,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public sil(byte value)
                => Data = value;

            public K Kind => K.SIL;

            public RegisterClass Class
                => RegisterClass.GP;

            [MethodImpl(Inline)]
            public static implicit operator R8(sil src)
                => new R8(src.Data, src.Kind);
        }

        public struct dil : IRegister<dil,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public dil(byte value)
                => Data = value;

            public K Kind => K.DIL;

            public RegisterClass Class
                => RegisterClass.GP;

            [MethodImpl(Inline)]
            public static implicit operator R8(dil src)
                => new R8(src.Data, src.Kind);

        }

        public struct spl : IRegister<spl,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public spl(byte value)
                => Data = value;

            public K Kind => K.SPL;

            public RegisterClass Class
                => RegisterClass.GP;

            [MethodImpl(Inline)]
            public static implicit operator R8(spl src)
                => new R8(src.Data, src.Kind);
        }

        public struct bpl : IRegister<bpl,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public bpl(byte value)
                => Data = value;

            public K Kind => K.BPL;

            [MethodImpl(Inline)]
            public static implicit operator R8(bpl src)
                => new R8(src.Data, src.Kind);
        }

        public struct r8b : IRegister<r8b,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;


            [MethodImpl(Inline)]
            public r8b(byte value)
                => Data = value;

            public K Kind => K.R8L;


            [MethodImpl(Inline)]
            public static implicit operator R8(r8b src)
                => new R8(src.Data, src.Kind);
        }

        public struct r9b : IRegister<r9b,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public r9b(byte value)
                => Data = value;

            public K Kind => K.R9L;

            [MethodImpl(Inline)]
            public static implicit operator R8(r9b src)
                => new R8(src.Data, src.Kind);
        }

        public struct r10b : IRegister<r10b,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public r10b(byte value)
                => Data = value;

            public K Kind => K.R10L;

            [MethodImpl(Inline)]
            public static implicit operator R8(r10b src)
                => new R8(src.Data, src.Kind);
        }

        public struct r11b : IRegister<r11b,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r11b(byte value)
                => Data = value;

            public K Kind => K.R11L;

            public RegisterClass Class
                => RegisterClass.GP;
        }

        public struct r12b : IRegister<r12b,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r12b(byte value)
                => Data = value;

            public K Kind => K.R12L;

            public RegisterClass Class
                => RegisterClass.GP;
        }

        public struct r13b : IRegister<r13b,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r13b(byte value)
                => Data = value;

            public K Kind => K.R13L;

            public RegisterClass Class
                => RegisterClass.GP;
        }

        public struct r14b : IRegister<r14b,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r14b(byte value)
                => Data = value;

            public K Kind => K.R14L;

            public RegisterClass Class
                => RegisterClass.GP;
        }

        public struct r15b : IRegister<r15b,W8,byte>
        {
            public byte Data;

            byte IContented<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get => new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r15b(byte value)
                => Data = value;

            public K Kind => K.R15L;
            public RegisterClass Class

                => RegisterClass.GP;
       }
    }
}