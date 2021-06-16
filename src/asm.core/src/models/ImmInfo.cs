//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    using W = NumericWidth;

    /// <summary>
    /// Describes an immediate value in the context of an asm instruction operand
    /// </summary>
    public struct ImmInfo
    {
        [MethodImpl(Inline), Op]
        public static ImmInfo imm(byte value, bool direct)
            => new ImmInfo(W.W8, value, direct);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(short value, bool direct, Sx sek)
            => new ImmInfo(W.W16, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(ushort value, bool direct)
            => new ImmInfo(W.W16, value, direct);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(int value, bool direct, Sx sek)
            => new ImmInfo(W.W32, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(uint value, bool direct)
            => new ImmInfo(W.W32, value, direct);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(long value, bool direct, Sx sek)
            => new ImmInfo(W.W64, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static ImmInfo imm(ulong value, bool direct)
            => new ImmInfo(W.W64, value, direct);

        public NumericWidth Width;

        public ulong Value;

        public bool Signed;

        public bool Direct;

        public Sx SignExtension;

        [MethodImpl(Inline)]
        public ImmInfo(NumericWidth size, ulong value, bool direct, Sx sek)
        {
            Width = size;
            Value = value;
            Signed = false;
            Direct = direct;
            SignExtension = sek;
        }

        [MethodImpl(Inline)]
        public ImmInfo(NumericWidth size, ulong value, bool direct)
        {
            Width = size;
            Value = value;
            Signed = false;
            Direct = direct;
            SignExtension = Sx.None;
        }

        [MethodImpl(Inline)]
        public ImmInfo(NumericWidth size, long value, bool direct)
        {
            Width = size;
            Value = (ulong)value;
            Signed = true;
            Direct = direct;
            SignExtension = Sx.None;
        }

        [MethodImpl(Inline)]
        public ImmInfo(NumericWidth size, long value, bool direct, Sx sek)
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