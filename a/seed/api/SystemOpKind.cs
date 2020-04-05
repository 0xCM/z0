//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum SystemOpKind : ulong
    {
        None = 0,
        
        /// <summary>
        /// Identifies operations that allocate memory/resources
        /// </summary>
        Alloc = 1,

        /// <summary>
        /// Identifies operations that move data from A -> B
        /// </summary>
        Store = 2,

        /// <summary>
        /// Identifies operations that move data from B -> A
        /// </summary>
        Load = 4
    }
}
