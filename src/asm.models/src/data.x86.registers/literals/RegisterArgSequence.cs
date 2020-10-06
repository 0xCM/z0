//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore; 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines the order in which registers with the <see cref='RegAspectKind.ArgSequence'/> aspect are used
    /// </summary>
    public enum RegisterArgSequence : byte
    {
        /// <summary>
        /// Specifies the first 64-bit argument index
        /// </summary>
        RDI = 0,

        /// <summary>
        /// Specifies the 64-bit register populated with the value of the second argument
        /// </summary>
        RSI = 1,

        /// <summary>
        /// Specifies the 64-bit register populated with the value of the third argument
        /// </summary>
        RDX = 2,

        /// <summary>
        /// Specifies the 64-bit register populated with the value of the fourth argument
        /// </summary>
        RCX = 2,

        /// <summary>
        /// Specifies the 64-bit register populated with the value of the fifth argument
        /// </summary>
        R8Q = 4,

        /// <summary>
        /// Specifies the 64-bit register populated with the value of the sizth argument
        /// </summary>
        R9Q = 5
    }
}