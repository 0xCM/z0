//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public readonly partial struct SpanReader : IApiHost<SpanReader>
    {
        public static SpanReader Service => default;

    }
}