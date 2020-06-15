//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// A memory location used by an instruction
    /// </summary>
    public struct UsedMemoryRecord 
    {
        public UsedMemoryRecord(
            Register Segment, 
            Register Base, 
            Register Index, 
            int Scale, 
            ulong Displacement, 
            MemorySize MemorySize,
            OpAccess Access)
        {
            this.Segment = Segment;
            this.Base = Base;
            this.Index = Index;
            this.Scale = Scale;
            this.Displacement = Displacement;
            this.MemorySize = MemorySize;
            this.Access = Access;
        }
        
        /// <summary>
        /// Effective segment register
        /// </summary>
        public readonly Register Segment;

        /// <summary>
        /// The base register, if any
        /// </summary>
        public readonly Register Base;

        /// <summary>
        /// The index register, if any
        /// </summary>
        public readonly Register Index;

        /// <summary>
        /// Index scale (1, 2, 4 or 8)
        /// </summary>
        public readonly int Scale;

        /// <summary>
        /// Displacement
        /// </summary>
        public readonly ulong Displacement;

        /// <summary>
        /// Size of location
        /// </summary>
        public readonly MemorySize MemorySize;

        /// <summary>
        /// Memory access
        /// </summary>
        public readonly OpAccess Access;
    }
}