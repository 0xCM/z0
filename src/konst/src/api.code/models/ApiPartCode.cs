//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ApiPartCode
    {
        /// <summary>
        /// The owning part
        /// </summary>
        public readonly PartId Part;

        /// <summary>
        /// The code in the set
        /// </summary>
        public Index<ApiHostCode> HostCode {get;}

        [MethodImpl(Inline)]
        public ApiPartCode(PartId part, ApiHostCode[] src)
        {
            Part = part;
            HostCode = src;
        }


        public Span<ApiHostCode> Edit
        {
            [MethodImpl(Inline)]
            get => HostCode.Edit;
        }

        public ReadOnlySpan<ApiHostCode> View
        {
            [MethodImpl(Inline)]
            get => HostCode.View;
        }
    }
}