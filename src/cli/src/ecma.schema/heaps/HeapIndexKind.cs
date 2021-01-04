//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
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
        UserString,

        /// <summary>
        /// Identifies a system string index
        /// </summary>
        SystemString,

        /// <summary>
        /// Identifies a blob index
        /// </summary>
        Blob,

        /// <summary>
        /// Identifies a guid index
        /// </summary>
        Guid
    }
}