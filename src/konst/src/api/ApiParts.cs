//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiParts
    {
        /// <summary>
        /// The members of the compostion
        /// </summary>
        readonly IPart[] Storage;

        public static implicit operator ApiParts(IPart[] src)
            => new ApiParts(src);

        public static implicit operator IPart[](ApiParts src)
            => src.Storage;

        [MethodImpl(Inline)]
        public ApiParts(IPart[] parts)
        {
            Storage = parts;
        }

        public Count32 Count
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }

        public ReadOnlySpan<IPart> View
        {
            [MethodImpl(Inline)]
            get => Storage;
        }
    }
}