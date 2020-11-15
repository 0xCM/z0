//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Defines tool archive classifiers
    /// </summary>
    public enum ToolArchiveKind : byte
    {
        None,

        /// <summary>
        /// Classifies an input file archive
        /// </summary>
        Source,

        /// <summary>
        /// Classifies a raw output file archive
        /// </summary>
        Target,

        /// <summary>
        /// Classifies a processed file archive
        /// </summary>
        Processed,
    }
}