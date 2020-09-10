//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Describes an immediate value in the context of an asm instruction operand
    /// </summary>
    public struct ImmInfo
    {
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
        public ImmInfo(NumericWidth size, long value, bool direct, Sx? sek = null)
        {
            Width = size;
            Value = (ulong)value;
            Signed = true;
            Direct = direct;
            SignExtension = sek ?? Sx.None;
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

        public static ImmInfo Empty
            => default;
    }
}