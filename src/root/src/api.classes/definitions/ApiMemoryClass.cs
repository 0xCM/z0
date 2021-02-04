//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiClass]
    public enum ApiMemoryClass : ushort
    {
        None = 0,

        /// <summary>
        /// Identifies operations that allocate memory/resources
        /// </summary>
        Alloc = ApiClass.Alloc,

        /// <summary>
        /// Identifies operations that move data from B -> A
        /// </summary>
        Load = ApiClass.Load,

        /// <summary>
        /// Identifies operations that move data from A -> B
        /// </summary>
        Store = ApiClass.Store,

        /// <summary>
        /// Identifies an operation that accepts a memory buffer, such as a memory segmented covered by an S-span,
        /// and returns the buffer unaltered but with an alternate presentation, such as a T-span
        /// </summary>
        Recover = ApiClass.Recover,

        MemAdd = ApiClass.MemAdd,

        MemSub = ApiClass.MemSub,
    }
}