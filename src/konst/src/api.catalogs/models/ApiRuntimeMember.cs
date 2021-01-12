//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ApiRuntimeMember : IRecord<ApiRuntimeMember>
    {
        public const string TableId ="api.member";

        public MemoryAddress Address;

        public OpUri Uri;

        public ClrDisplaySig Sig;

        public CilMethod Cil;
    }
}