//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Describes an immediate value in the context of an asm instruction operand
    /// </summary>
    public struct AsmImmInfo
    {
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