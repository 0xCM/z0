//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    /// <summary>
    /// Defines content type classifiers, and occupies at most 3 bits
    /// </summary>
    [FieldComponent(typeof(ContentField))]
    public enum ContentType : byte
    {
        /// <summary>
        /// Text content
        /// </summary>
        Text = 0,

        /// <summary>
        /// A table
        /// </summary>
        Table = 1,
    }
}