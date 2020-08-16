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
    [Table]
    public readonly struct ImmInfo : ITable<ImmInfo>
    {
        public readonly NumericWidth Width;

        public readonly ulong Value;

        public readonly bool Signed;

        public readonly bool Direct;

        public readonly SignExtensionKind SignExtension;

        [MethodImpl(Inline)]
        public ImmInfo(NumericWidth size, ulong value, bool direct, SignExtensionKind sek)
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
            SignExtension = SignExtensionKind.None;
        }

        [MethodImpl(Inline)]
        public ImmInfo(NumericWidth size, long value, bool direct, SignExtensionKind? sek = null)
        {
            Width = size;
            Value = (ulong)value;
            Signed = true;
            Direct = direct;
            SignExtension = sek ?? SignExtensionKind.None;
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