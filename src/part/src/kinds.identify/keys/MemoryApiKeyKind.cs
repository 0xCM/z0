//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum MemoryApiKey : ushort
    {
        None = 0,

        /// <summary>
        /// Identifies operations that allocate memory/resources
        /// </summary>
        Alloc = ApiKeyId.Alloc,

        /// <summary>
        /// Identifies operations that move data from A -> B
        /// </summary>
        Store = ApiKeyId.Store,

        /// <summary>
        /// Identifies operations that move data from B -> A
        /// </summary>
        Load = ApiKeyId.Load,

        /// <summary>
        /// Identifies an operation that accepts a memory buffer, such as a memory segmented covered by an S-span,
        /// and returns the buffer unaltered but with an alternate presentation, such as a T-span
        /// </summary>
        Recover = ApiKeyId.Recover,
    }
}