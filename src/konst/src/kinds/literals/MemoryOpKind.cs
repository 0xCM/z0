//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum MemoryOpKind : ulong
    {
        None = 0,

        /// <summary>
        /// Identifies operations that allocate memory/resources
        /// </summary>
        Alloc = OpKindId.Alloc,

        /// <summary>
        /// Identifies operations that move data from A -> B
        /// </summary>
        Store = OpKindId.Store,

        /// <summary>
        /// Identifies operations that move data from B -> A
        /// </summary>
        Load = OpKindId.Load,

        /// <summary>
        /// Identifies an operation that accepts a memory buffer, such as a memory segmented covered by an S-span, 
        /// and returns the buffer unaltered but with an alternate presentation, such as a T-span
        /// </summary>        
        Recover = OpKindId.Recover,

    }
}