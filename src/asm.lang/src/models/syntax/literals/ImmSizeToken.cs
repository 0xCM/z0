//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using SD = AsmSyntaxDocs;

    /// <summary>
    /// Specifies the size of an immediate operand in the context of an opcode specification
    /// </summary>
    public enum ImmSizeToken : byte
    {
        /// <summary>
        /// A size of one byte as described by <see cref='SD.ib'/>
        /// </summary>
        [Symbol("ib")]
        ib = 1,

        /// <summary>
        /// A size of two bytes as described by <see cref='SD.iw'/>
        /// </summary>
        [Symbol("iw")]
        iw = 2,

        /// <summary>
        /// A size of four bytes as described by <see cref='SD.id'/>
        /// </summary>
        [Symbol("id")]
        id = 4,

        /// <summary>
        /// A size of eiqht bytes as described by <see cref='SD.io'/>
        /// </summary>
        [Symbol("io")]
        io = 8,
    }
}