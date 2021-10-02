//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct RuleModels
    {
        /// <summary>
        /// Defines comment classifiers
        /// </summary>
        public enum CommentKind : byte
        {
            None,

            /// <summary>
            /// Comment follows code on same line
            /// </summary>
            PostFix,

            /// <summary>
            /// Comment is self-contained within a line of code
            /// </summary>
            Embedded,

            /// <summary>
            /// Comment occupies an enire line
            /// </summary>
            FullLine,

            /// <summary>
            /// Comment occupies multiple lines
            /// </summary>
            MultiLine,
        }
    }
}