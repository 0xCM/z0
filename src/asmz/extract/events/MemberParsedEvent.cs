//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class MemberParsedEvent : ApiExtractEvent<MemberParsedEvent,DataFlow<ApiMemberExtract,ApiMemberCode>>
    {
        [MethodImpl(Inline)]
        public MemberParsedEvent()
        {
            Payload = Relations.flow(ApiMemberExtract.Empty, ApiMemberCode.Empty);

        }

        [MethodImpl(Inline)]
        public MemberParsedEvent(in ApiMemberExtract src, in ApiMemberCode dst)
        {
            Payload = Relations.flow(src,dst);
        }
    }
}