//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [SymbolSource]
    public enum RelToken : byte
    {
        [Symbol("rel8", "A relative address in the range from 128 bytes before the end of the instruction to 127 bytes after the end of the instruction")]
        rel8,

        [Symbol("rel16", "A relative address within the same code segment as the instruction assembled. The rel16 symbol applies to instructions with an operand-size attribute of 16 bits")]
        rel16,

        [Symbol("rel32", "A relative address within the same code segment as the instruction assembled. The rel32 symbol applies to instructions with an operand-size attribute of 32 bits")]
        rel32,
    }
}