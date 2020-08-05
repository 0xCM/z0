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
    public readonly struct ImmInfo : INullity
    {
        public readonly NumericWidth Width;

        public readonly ulong Value;

        public readonly bool Signed;

        public readonly bool Direct;

        public readonly SignExensionKind SignExension;

        [MethodImpl(Inline)]
        public ImmInfo(NumericWidth size, ulong value, bool direct, SignExensionKind sek)
        {
            Width = size;
            Value = value;
            Signed = false;
            Direct = direct;
            SignExension = sek;
        }

        [MethodImpl(Inline)]
        public ImmInfo(NumericWidth size, ulong value, bool direct)
        {
            Width = size;
            Value = value;
            Signed = false;
            Direct = direct;
            SignExension = SignExensionKind.None;
        }

        [MethodImpl(Inline)]
        public ImmInfo(NumericWidth size, long value, bool direct, SignExensionKind? sek = null)
        {
            Width = size;
            Value = (ulong)value;
            Signed = true;
            Direct = direct;
            SignExension = sek ?? SignExensionKind.None;
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