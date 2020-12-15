//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiPartCodeBlocks
    {
        /// <summary>
        /// The owning part
        /// </summary>
        public readonly PartId Part;

        /// <summary>
        /// The code in the set
        /// </summary>
        readonly TableSpan<ApiHostCodeBlocks> Data;

        [MethodImpl(Inline)]
        public ApiPartCodeBlocks(PartId part, ApiHostCodeBlocks[] src)
        {
            Part = part;
            Data = src;
        }

        public Span<ApiHostCodeBlocks> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<ApiHostCodeBlocks> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }
    }
}