//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.AsmSpecs
{
    using System;

    /// <summary>
    /// A memory location used by an instruction
    /// </summary>
    public struct UsedMemory 
    {
        /// <summary>
        /// Captures the result of the ToString() method at the time of replication
        /// </summary>
        public string Formatted {get; set;}

        /// <summary>
        /// Effective segment register
        /// </summary>
        public Register Segment {get;set;}

        /// <summary>
        /// Base register or <see cref="Register.None"/> if none
        /// </summary>
        public Register Base {get;set;}

        /// <summary>
        /// Index register or <see cref="Register.None"/> if none
        /// </summary>
        public Register Index {get;set;}

        /// <summary>
        /// Index scale (1, 2, 4 or 8)
        /// </summary>
        public int Scale {get;set;}

        /// <summary>
        /// Displacement
        /// </summary>
        public ulong Displacement {get;set;}

        /// <summary>
        /// Size of location
        /// </summary>
        public MemorySize MemorySize {get;set;}

        /// <summary>
        /// Memory access
        /// </summary>
        public OpAccess Access {get;set;}

    }
}