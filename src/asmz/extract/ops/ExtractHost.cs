//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial class ApiExtractor
    {
        ApiHostDataset ExtractHost(in ResolvedHost src)
        {
            var dst = new ApiHostDataset();
            dst.HostResolution = src;
            var host = src.Host;
            var extracts = Extractor.ExtractHost(src).Sort();
            dst.HostExtracts = extracts;
            EmitRawExtractData(host, extracts.View);
            var parsed = ParseExtracts(extracts.View);
            dst.HostBlocks = parsed;
            EmitParsedExtractData(host, parsed.View);
            var decoded = DecodeMembers(parsed.View);
            dst.Routines = decoded;
            EmitAsmSource(host, decoded);
            return dst;
        }
    }
}