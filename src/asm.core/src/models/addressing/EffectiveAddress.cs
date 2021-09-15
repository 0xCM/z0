//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.InteropServices;

    /// <summary>
    /// Represents an effective address as defined by Vol. 1 section 3.7.5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1), Record(TableId)]
    public struct EffectiveAddress : IRecord<EffectiveAddress>
    {
        public const string TableId = "asm.effective";

        /// <summary>
        /// The base register
        /// </summary>
        public RegIndex Base;

        /// <summary>
        /// The index register
        /// </summary>
        public RegIndex Index;

        /// <summary>
        /// The scale factor; one of 1, 2, 4, 8
        /// </summary>
        public MemoryScale Scale;

        /// <summary>
        /// The common width of the base and index registers
        /// </summary>
        public NativeSizeCode RegWidth;

        /// <summary>
        /// An 8-bit, 16-bit or 32-bit displacement
        /// </summary>
        public Disp Disp;
    }
}