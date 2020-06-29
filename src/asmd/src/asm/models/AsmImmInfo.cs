//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static NumericWidth;

    /// <summary>
    /// Describes an immediate value in the context of an asm instruction operand
    /// </summary>
    public readonly struct AsmImmInfo : INullity
    {
        public NumericWidth Width {get;}

        public ulong Value {get;}

        public bool Signed {get;}

        public bool Direct {get;}

        public SignExensionKind SignExension {get;}

        [MethodImpl(Inline)]
        public static AsmImmInfo Define(byte value, bool direct, SignExensionKind? sek = null)
            => new AsmImmInfo(W8, value, direct, sek);

        [MethodImpl(Inline)]
        public static AsmImmInfo Define(short value, bool direct, SignExensionKind? sek = null)
            => new AsmImmInfo(W16, value, direct, sek);

        [MethodImpl(Inline)]
        public static AsmImmInfo Define(ushort value, bool direct, SignExensionKind? sek = null)
            => new AsmImmInfo(W16, value, direct, sek);

        [MethodImpl(Inline)]
        public static AsmImmInfo Define(int value, bool direct, SignExensionKind? sek = null)
            => new AsmImmInfo(W32, value, direct, sek);

        [MethodImpl(Inline)]
        public static AsmImmInfo Define(uint value, bool direct, SignExensionKind? sek = null)
            => new AsmImmInfo(W32, value, direct, sek);

        [MethodImpl(Inline)]
        public static AsmImmInfo Define(long value, bool direct, SignExensionKind? sek = null)
            => new AsmImmInfo(W64, value, direct, sek);

        [MethodImpl(Inline)]
        public static AsmImmInfo Define(ulong value, bool direct, SignExensionKind? sek = null)
            => new AsmImmInfo(W64, value, direct, sek);

        [MethodImpl(Inline)]
        internal AsmImmInfo(NumericWidth size, ulong value, bool direct, SignExensionKind? sek = null)
        {
            Width = size;
            Value = value;
            Signed = false;
            Direct = direct;
            SignExension = sek ?? SignExensionKind.None;
        }

        [MethodImpl(Inline)]
        internal AsmImmInfo(NumericWidth size, long value, bool direct, SignExensionKind? sek = null)
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

        public static AsmImmInfo Empty 
            => default;

    }
}