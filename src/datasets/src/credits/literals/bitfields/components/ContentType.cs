//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{                
    partial class CreditTypes
    {
        /// <summary>
        /// Defines content type classifiers, and occupies at most 3 bits
        /// </summary>
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
}