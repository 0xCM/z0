//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IEmissionMatchStep : ICaptureStep
    {
        void MatchEmissions(ApiHostUri host, ReadOnlySpan<UriHex> srcA, FilePath srcB);
    }
}