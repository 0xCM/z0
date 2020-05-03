//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Describes an immediate value in the context of an asm instruction operand
    /// </summary>
    public readonly struct AsmImmInfo
    {
        public static AsmImmInfo Empty => default(AsmImmInfo);

        public readonly int Size;

        public readonly ulong Value;

        public readonly bool Signed;

        [MethodImpl(Inline)]
        public static AsmImmInfo Define(int size, long value, bool signed = true)
            => new AsmImmInfo(size, value, signed);

        [MethodImpl(Inline)]
        public static AsmImmInfo Define(int size, ulong value, bool signed = false)
            => new AsmImmInfo(size, value, signed);

        [MethodImpl(Inline)]
        AsmImmInfo(int size, ulong value, bool signed = false)
        {
            this.Size = size;
            this.Value = value;
            this.Signed = signed;
        }

        [MethodImpl(Inline)]
        AsmImmInfo(int size, long value, bool signed = true)
        {
            this.Size = size;
            this.Value = (ulong)value;
            this.Signed = signed;
        }

        /// <summary>
        /// Specifies a label for the immedate that has the form imm{BitWidth}
        /// </summary>
        public string Label
            => $"imm{Size}";
        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Size == 0 && Value == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => !IsEmpty;
        }        
        
    }
}