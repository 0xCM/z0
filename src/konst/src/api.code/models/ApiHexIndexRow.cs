//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Record(TableId)]
    public struct ApiHexIndexRow : IRecord<ApiHexIndexRow>
    {
        public const string TableId = "api-hex-index";

        public uint Seqence;

        public MemoryAddress Address;

        public string Name;

        public CliSig Sig;

        public OpUri Uri;
    }
}