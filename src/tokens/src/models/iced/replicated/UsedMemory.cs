//-----------------------------------------------------------------------------
// Taken from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// A memory location used by an instruction
    /// </summary>
    public struct UsedMemory 
    {
        public UsedMemory(
            string Formatted, 
            Register Segment, 
            Register Base, 
            Register Index, 
            int Scale, 
            ulong Displacement, 
            MemorySize MemorySize,
            OpAccess Access
            )
        {
            this.Formatted = Formatted;
            this.Segment = Segment;
            this.Base = Base;
            this.Index = Index;
            this.Scale = Scale;
            this.Displacement = Displacement;
            this.MemorySize = MemorySize;
            this.Access = Access;
        }

        /// <summary>
        /// Captures the result of the ToString() method at the time of replication
        /// </summary>
        public readonly string Formatted;

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