//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ApiHexIndexRow : IRecord<ApiHexIndexRow>
    {
        public const string TableId = "api-hex-index";

        public uint Seqence;

        public MemoryAddress Address;

        public string Component;

        public string HostName;

        public string MethodName;

        public OpUri Uri;
    }
}