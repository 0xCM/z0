//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public enum SystemApiKeyKind : ushort
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
        /// Identifies operations that initialize a resource where allocation may be required...or not
        /// </summary>
        Init = ApiKeyKind.Init,

        /// <summary>
        /// Identifies operations assign kind classifiers
        /// </summary>
        Kind = ApiKeyKind.Kind
    }
}