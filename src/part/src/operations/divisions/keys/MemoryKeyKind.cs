//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum MemoryApiKeyKind : ushort
    {
        None = 0,

        /// <summary>
        /// Identifies operations that allocate memory/resources
        /// </summary>
        Alloc = ApiKeyKind.Alloc,

        /// <summary>
        /// Identifies operations that move data from A -> B
        /// </summary>
        Store = ApiKeyKind.Store,

        /// <summary>
        /// Identifies operations that move data from B -> A
        /// </summary>
        Load = ApiKeyKind.Load,

        /// <summary>
        /// Identifies an operation that accepts a memory buffer, such as a memory segmented covered by an S-span,
        /// and returns the buffer unaltered but with an alternate presentation, such as a T-span
        /// </summary>
        Recover = ApiKeyKind.Recover,

    }
}