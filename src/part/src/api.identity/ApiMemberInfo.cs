//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct ApiMemberInfo : IRecord<ApiMemberInfo>
    {
        public const string TableId = "api.members";

        public MemoryAddress Address;

        public Name Host;

        public Name Member;

        public ApiClass ApiKind;

        public TextBlock Uri;
    }
}