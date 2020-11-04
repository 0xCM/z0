//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum SystemApiClass : ushort
    {
        None = 0,

        /// <summary>
        /// Identifies operations that allocate memory/resources
        /// </summary>
        Alloc = ApiClass.Alloc,

        /// <summary>
        /// Identifies operations that move data from A -> B
        /// </summary>
        Store = ApiClass.Store,

        /// <summary>
        /// Identifies operations that move data from B -> A
        /// </summary>
        Load = ApiClass.Load,

        /// <summary>
        /// Identifies operations that initialize a resource where allocation may be required...or not
        /// </summary>
        Init = ApiClass.Init,

        /// <summary>
        /// Identifies operations assign kind classifiers
        /// </summary>
        Kind = ApiClass.Kind
    }
}