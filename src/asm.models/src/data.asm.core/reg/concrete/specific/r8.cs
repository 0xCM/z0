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

    partial struct AsmRegisterTypes
    {
        public readonly struct al : IRegister<al,W8,byte,N0>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            [MethodImpl(Inline)]
            public static implicit operator R8(al src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public al(byte value)
                => Data = value;

            public K Kind
                => K.AL;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }
        }

        public readonly struct cl : IRegister<cl,W8,byte,N1>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public cl(byte value)
            {
                Data = value;
            }

            [MethodImpl(Inline)]
            public static implicit operator R8(cl src)
                => src.Generalized;

            public K Kind => K.CL;
        }

        public readonly struct dl : IRegister<dl,W8,byte,N2>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator R8(dl src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public dl(byte value)
            {
                Data = value;
            }

            public K Kind => K.DL;
        }

        public readonly struct bl : IRegister<bl,W8,byte,N3>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator R8(bl src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public bl(byte value)
            {
                Data = value;
            }

            public K Kind => K.BL;

        }

        public readonly struct sil : IRegister<sil,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator R8(sil src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public sil(byte value)
            {
                Data = value;
            }

            public K Kind => K.SIL;
        }

        public readonly struct dil : IRegister<dil,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator R8(dil src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public dil(byte value)
            {
                Data = value;
            }

            public K Kind => K.DIL;

        }

        public readonly struct spl : IRegister<spl,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator R8(spl src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public spl(byte value)
            {
                Data = value;
            }
            public K Kind => K.SPL;

        }

        public readonly struct bpl : IRegister<bpl,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator R8(bpl src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public bpl(byte value)
            {
                Data = value;
            }

            public K Kind => K.BPL;
        }

        public readonly struct r8b : IRegister<r8b,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public static implicit operator R8(r8b src)
                => src.Generalized;

            [MethodImpl(Inline)]
            public r8b(byte value)
            {
                Data = value;
            }

            public K Kind => K.R8L;

        }

        public readonly struct r9b : IRegister<r9b,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r9b(byte value)
            {
                Data = value;
            }

            public K Kind => K.R9L;
        }

        public readonly struct r10b : IRegister<r10b,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r10b(byte value)
            {
                Data = value;
            }

            public K Kind => K.R10L;
        }

        public readonly struct r11b : IRegister<r11b,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r11b(byte value)
            {
                Data = value;
            }

            public K Kind => K.R11L;

        }

        public readonly struct r12b : IRegister<r12b,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r12b(byte value)
            {
                Data = value;
            }

            public K Kind => K.R12L;
        }

        public readonly struct r13b : IRegister<r13b,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r13b(byte value)
            {
                Data = value;
            }

            public K Kind => K.R13L;

        }

        public readonly struct r14b : IRegister<r14b,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get =>new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r14b(byte value)
            {
                Data = value;
            }

            public K Kind => K.R14L;

        }

        public readonly struct r15b : IRegister<r15b,W8,byte>
        {
            public readonly byte Data;

            byte IRegister<byte>.Content
                => Data;

            public R8 Generalized
            {
                [MethodImpl(Inline)]
                get => new R8(Data, Kind);
            }

            [MethodImpl(Inline)]
            public r15b(byte value)
            {
                Data = value;
            }

            public K Kind => K.R15L;
        }
    }
}