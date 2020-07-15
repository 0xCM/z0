//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Defines a pairing that captures a content payload with specification that defines how content attributes/aspects
    /// should be organized/arranged with respect to either a text-based representation or a binary representation
    /// </summary>
    public readonly struct StructuredContent<S,C>
    {
        public readonly S Structure;
        public readonly C Content;

        [MethodImpl(Inline)]
        public StructuredContent(S structure, C content)
        {
            Structure = structure;
            Content = content;
        }        
    }
}