//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmX
    {
        [SymbolSource]
        public enum MemToken : byte
        {
            [Symbol("m", "An operand in memory of width 16, 32 or 64 bits")]
            m,

            [Symbol("mem")]
            mem,

            [Symbol("m8", "A byte operand in memory ( usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. In 64-bit mode, it is pointed to by the RSI or RDI registers")]
            m8,

            [Symbol("m16", "A word operand in memory (usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. This nomenclature is used only with the string instructions")]
            m16,

            [Symbol("m32", "A doubleword operand in memory (usually expressed as a variable or array name) but pointed to by the DS:(E)SI or ES:(E)DI registers. This nomenclature is used only with the string instructions")]
            m32,

            [Symbol("m64", "A 64-bit operand in memory")]
            m64,

            [Symbol("m128", "A memory double quadword operand in memory")]
            m128,

            [Symbol("m256", "A 256-bit operand in memory. This nomenclature is used only with AVX instructions")]
            m256,

            [Symbol("m16int", "A word integer operand in memory. These symbols designate integers that are used as operands for x87 FPU integer instructions")]
            m16Int,

            [Symbol("m32int", "A doubleword integer operand in memory. These symbols designate integers that are used as operands for x87 FPU integer instructions")]
            m32Int,

            [Symbol("m64int", "A quadword integer operand in memory. These symbols designate integers that are used as operands for x87 FPU integer instructions")]
            m64Int,

            /// <summary>
            /// A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.
            /// All memory addressing modes are allowed. Ussed by the BOUND instruction to provide an operand containing an
            /// upper and lower bounds for array indices, E.G. BOUND r16, m16&16
            /// </summary>
            [Symbol("m16&16", "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.")]
            m16x16,

            /// <summary>
            /// A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.
            /// All memory addressing modes are allowed. The operand is used by the BOUND instruction to provide an operand containing an
            /// upper and lower bounds for array indices.
            /// </summary>
            [Symbol("m16&32", "A memory operand consisting of data item pairs whose sizes are indicated on the left and the right side of the ampersand.")]
            m16x32,
        }
    }
}