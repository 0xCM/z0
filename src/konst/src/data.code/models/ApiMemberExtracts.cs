//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiMemberExtracts
    {
        readonly TableSpan<ApiMemberExtract> Data;

        [MethodImpl(Inline)]
        public static implicit operator ApiMemberExtracts(ApiMemberExtract[] src)
            => new ApiMemberExtracts(src);

        [MethodImpl(Inline)]
        public ApiMemberExtracts(ApiMemberExtract[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ApiMemberExtract[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }

}