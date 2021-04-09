//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmLang
    {
        [SymbolSource]
        public enum PtrToken : byte
        {
            /// <summary>
            /// A far pointer typically to a code segment different from that of the instruction. The notation 16:16 indicates that the
            /// value of the pointer has two parts. The value to the left of the colon is a 16- bit selector or value destined
            /// for the code segment register. The value to the right corresponds to the offset within the destination segment.
            /// The ptr16:16 symbol is used when the instruction's operand-size attribute is 16 bits
            /// E.G, CALL ptr16:16 (Call far, absolute, address given in operand)
            /// </summary>
            [Symbol("ptr16:16")]
            ptr16x16,

            /// <summary>
            /// A far pointer typically to a code segment different from that of the instruction and similar to ptr16:16 notation;
            /// in this case the ptr16:32 symbol is used when the operand-size attribute is 32 bits
            /// A memory operand using SIB addressing form, where the index register is not used in address calculation, Scale is ignored.
            /// Only the base and displacement are used in effective address calculation
            /// E.G, CALL ptr16:32 (Call far, absolute, address given in operand)
            /// </summary>
            [Symbol("ptr16:32")]
            ptr16x32,
        }
    }
}