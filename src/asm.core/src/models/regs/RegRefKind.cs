//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    [SymSource]
    public enum RegRefKind : byte
    {
        None,

        /// <summary>
        /// The literal register bits
        /// </summary>
        [Symbol("r")]
        RegisterContent,

        /// <summary>
        /// The bits reference by an address in a register
        /// </summary>
        [Symbol("[r]")]
        ContentOfAddress
    }
}