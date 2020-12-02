//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op]
        public static ClaimFailedEvent failed(ClaimKind claim, string description, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new ClaimFailedEvent(claim,description, CallingMember.define(caller,file,line), CorrelationToken.Empty);

        [MethodImpl(Inline), Op]
        public static ClaimFailedEvent failed(ClaimKind claim, string description, CallingMember origin, PartId part = 0)
            => new ClaimFailedEvent(claim,description, origin, part);
    }
}