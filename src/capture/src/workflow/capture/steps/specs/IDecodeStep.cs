//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IDecodeStep : ICaptureStep
    {
        AsmFunction[] DecodeParsed(ApiHostUri host, ParsedMember[] parsed);

        AsmFunction[] DecodeExtracts(params ParsedMember[] src);

        void SaveDecoded(AsmFunction[] src, FilePath dst);
    }
}