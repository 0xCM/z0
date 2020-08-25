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

    public readonly struct al : IRegOperand<al,W8,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct cl : IRegOperand<cl,W8,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct dl : IRegOperand<dl,W8,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct bl : IRegOperand<bl,W8,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct sil : IRegOperand<sil,W8,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct dil : IRegOperand<dil,W8,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct spl : IRegOperand8<spl,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct bpl : IRegOperand8<bpl,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct r8b : IRegOperand8<r8b,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct r9b : IRegOperand8<r9b,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct r10b : IRegOperand8<r10b,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct r11b : IRegOperand8<r11b,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct r12b : IRegOperand8<r12b,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct r13b : IRegOperand8<r13b,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct r14b : IRegOperand8<r14b,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
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

    public readonly struct r15b : IRegOperand8<r15b,byte>
    {
        public readonly byte Data;

        byte IAsmOperand<byte>.Content
            => Data;

        public R8 Generalized
        {
            [MethodImpl(Inline)]
            get =>new R8(Data, Kind);
        }

        [MethodImpl(Inline)]
        public r15b(byte value)
        {
            Data = value;
        }

        public K Kind => K.R15L;
    }
}