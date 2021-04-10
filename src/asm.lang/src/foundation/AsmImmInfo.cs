//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using W = NumericWidth;

    /// <summary>
    /// Describes an immediate value in the context of an asm instruction operand
    /// </summary>
    public struct AsmImmInfo
    {
        [MethodImpl(Inline), Op]
        public static AsmImmInfo define(byte value, bool direct)
            => new AsmImmInfo(W.W8, value, direct);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo define(short value, bool direct, Sx sek)
            => new AsmImmInfo(W.W16, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo define(ushort value, bool direct)
            => new AsmImmInfo(W.W16, value, direct);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo define(int value, bool direct, Sx sek)
            => new AsmImmInfo(W.W32, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo define(uint value, bool direct)
            => new AsmImmInfo(W.W32, value, direct);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo define(long value, bool direct, Sx sek)
            => new AsmImmInfo(W.W64, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo define(ulong value, bool direct)
            => new AsmImmInfo(W.W64, value, direct);
        public NumericWidth Width;

        public ulong Value;

        public bool Signed;

        public bool Direct;

        public Sx SignExtension;

        [MethodImpl(Inline)]
        public AsmImmInfo(NumericWidth size, ulong value, bool direct, Sx sek)
        {
            Width = size;
            Value = value;
            Signed = false;
            Direct = direct;
            SignExtension = sek;
        }

        [MethodImpl(Inline)]
        public AsmImmInfo(NumericWidth size, ulong value, bool direct)
        {
            Width = size;
            Value = value;
            Signed = false;
            Direct = direct;
            SignExtension = Sx.None;
        }

        [MethodImpl(Inline)]
        public AsmImmInfo(NumericWidth size, long value, bool direct)
        {
            Width = size;
            Value = (ulong)value;
            Signed = true;
            Direct = direct;
            SignExtension = Sx.None;
        }

        [MethodImpl(Inline)]
        public AsmImmInfo(NumericWidth size, long value, bool direct, Sx sek)
        {
            Width = size;
            Value = (ulong)value;
            Signed = true;
            Direct = direct;
            SignExtension = sek;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Width == 0 && Value == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }
    }
}