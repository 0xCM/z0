//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    /// <summary>
    /// Describes an immediate value in the context of an asm instruction operand
    /// </summary>
    public readonly struct ImmInfo
    {
        public readonly int Size;

        public readonly ulong Value;

        public readonly bool Signed;

        public static ImmInfo Define(int size, long value, bool signed = true)
            => new ImmInfo(size, value, signed);

        public static ImmInfo Define(int size, ulong value, bool signed = false)
            => new ImmInfo(size, value, signed);

        ImmInfo(int size, ulong value, bool signed = false)
        {
            this.Size = size;
            this.Value = value;
            this.Signed = signed;
        }

        ImmInfo(int size, long value, bool signed = true)
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
    }

}