//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using M = AsmSyntaxMeaning;

    partial struct AsmOpCodes
    {
        /// <summary>
        /// Specifies the size of an immediate operand in the context of an opcode specification
        /// </summary>
        public enum ImmSize : byte
        {
            /// <summary>
            /// A size of one byte as described by <see cref='M.ib'/>
            /// </summary>
            ib = 1,

            /// <summary>
            /// A size of two bytes as described by <see cref='M.iw'/>
            /// </summary>
            iw = 2,

            /// <summary>
            /// A size of four bytes as described by <see cref='M.id'/>
            /// </summary>
            id = 4,

            /// <summary>
            /// A size of eiqht bytes as described by <see cref='M.io'/>
            /// </summary>
            io = 8,
        }
    }
}