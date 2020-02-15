//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public static class EncodingServices
    {
        public static IEncodingExtractor EncodingExtractor(this IContext context, int? bufferlen = null)
            => Z0.EncodingExtractor.Create(context, bufferlen);

        public static IEncodingParser EncodingParser(this IContext context, int? bufferlen = null)
            => Z0.EncodingParser.Create(context, bufferlen);
    }
}