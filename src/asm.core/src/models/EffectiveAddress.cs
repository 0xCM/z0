//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    /// <summary>
    /// Represents an effective address as defined by Vol. 1 section 3.7.5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct EffectiveAddress
    {
        /// <summary>
        /// The common width of the base and index registers
        /// </summary>
        public RegWidthCode RegWidth;

        /// <summary>
        /// The base register
        /// </summary>
        public RegIndexCode Base;

        /// <summary>
        /// The index register
        /// </summary>
        public RegIndexCode Index;

        /// <summary>
        /// The scale factor; one of 1, 2, 4, 8
        /// </summary>
        public MemoryScale Scale;

        /// <summary>
        /// An 8-bit, 16-bit or 32-bit displacement
        /// </summary>
        public Disp Disp;
    }
}