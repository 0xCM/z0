//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    /// <summary>
    /// Classfies, to a degree, the lines found in a <see cref='NasmListing'/>
    /// </summary>
    public enum NasmListLineKind : byte
    {
        None = 0,

        /// <summary>
        /// The line specifies a label of the form {line_number}{identifier}{:}
        /// </summary>
        Label = 1,

        /// <summary>
        /// The begins with {line_number}{offset}{encoded_bytes}
        /// </summary>
        Encoding = 2,
    }
}