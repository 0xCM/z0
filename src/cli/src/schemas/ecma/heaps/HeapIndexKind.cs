//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    /// <summary>
    /// Defines a heap index classifier
    /// </summary>
    public enum HeapIndexKind : byte
    {
        None = 0,

        /// <summary>
        /// Identifies a user string index
        /// </summary>
        UserString = 1,

        /// <summary>
        /// Identifies a system string index
        /// </summary>
        SystemString = 2,

        /// <summary>
        /// Identifies a blob index
        /// </summary>
        Blob = 4,

        /// <summary>
        /// Identifies a guid index
        /// </summary>
        Guid = 8
    }
}