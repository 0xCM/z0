//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    /// <summary>
    /// Represents an effective address as defined by Vol. 1 section 3.7.5
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack=1), Record("asm.effective")]
    public struct EffectiveAddress : IRecord<EffectiveAddress>
    {
        [Flags]
        public enum ComponentKind : byte
        {
            None = 0,

            RegWidth = 1,

            Base = 2,

            Index = 4,

            Scale = 8,

            Disp = 16
        }

        /// <summary>
        /// The common width of the base and index registers
        /// </summary>
        public RegWidthCode RegWidth;

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
        /// An 8-bit, 16-bit or 32-bit displacement
        /// </summary>
        public Disp Disp;

        /// <summary>
        /// Specifies the components to include in computations/expressions
        /// </summary>
        public ComponentKind Components;

        [MethodImpl(Inline)]
        public bit Enabled(ComponentKind kind)
            => (kind & Components) != 0;
    }
}