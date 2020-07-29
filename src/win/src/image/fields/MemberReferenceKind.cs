//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    /// <summary>
    /// Indicates whether a <see cref="MemberReference"/> references a method or field.
    /// </summary>
    public enum MemberReferenceKind
    {
        /// <summary>
        /// The <see cref="MemberReference"/> references a method.
        /// </summary>
        Method,

        /// <summary>
        /// The <see cref="MemberReference"/> references a field.
        /// </summary>
        Field,
    }
}