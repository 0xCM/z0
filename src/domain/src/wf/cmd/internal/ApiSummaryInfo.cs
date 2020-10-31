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
    using static z;

    public struct ApiSummaryInfo : ITextual
    {
        const string RenderPattern = "| {0,-64} | {1}";

        [MethodImpl(Inline)]
        public static ApiSummaryInfo define(in ApiMetadataUri uri, in MethodMetadata sig)
        {
            var dst = new ApiSummaryInfo();
            dst.Uri = uri;
            dst.Sig = sig;
            return dst;
        }

        public ApiMetadataUri Uri;

        public MethodMetadata Sig;

        public string Format()
            => string.Format(RenderPattern, Uri,Sig);

        public override string ToString()
            => Format();
    }
}