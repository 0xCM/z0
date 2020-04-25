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
        /// Identifies operations that initalize a resource where allocation may be required...or not
        /// </summary>
        Init = OpKindId.Init,
    }
}
