//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct WfEvents
    {
        /// <summary>
        /// Defines a <see cref='AppMsgSource'/>
        /// </summary>
        /// <param name="caller">The member name</param>
        /// <param name="file">The caller file path</param>
        /// <param name="line">The caller line number</param>
        [MethodImpl(Inline), Op]
        public static AppMsgSource source([Caller]string caller = null, [File] string file = null, [Line] int? line = null)
            => new AppMsgSource(PartId.None, caller, file, line);


        [MethodImpl(Inline), Op]
        public static CallingMember caller([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new CallingMember(caller, file, line ?? 0);
    }
}