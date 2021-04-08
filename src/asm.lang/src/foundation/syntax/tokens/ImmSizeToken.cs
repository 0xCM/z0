//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using OCD = AsmOpCodeDocs;

    /// <summary>
    /// Specifies the size of an immediate operand in the context of an opcode specification
    /// </summary>
    [SymbolSource]
    public enum ImmSizeToken : byte
    {
        /// <summary>
        /// A size of one byte as described by <see cref='OCD.ib'/>
        /// </summary>
        [Symbol("ib", OCD.ib)]
        ib,

        /// <summary>
        /// A size of two bytes as described by <see cref='OCD.iw'/>
        /// </summary>
        [Symbol("iw", OCD.iw)]
        iw,

        /// <summary>
        /// A size of four bytes as described by <see cref='OCD.id'/>
        /// </summary>
        [Symbol("id", OCD.id)]
        id,

        /// <summary>
        /// A size of eiqht bytes as described by <see cref='OCD.io'/>
        /// </summary>
        [Symbol("io", OCD.io)]
        io,
    }
}