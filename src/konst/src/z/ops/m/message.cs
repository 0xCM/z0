//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        public static AppMsg message(object content, AppMsgKind kind, AppMsgColor color, AppMsgSource src)
            => new AppMsg(new AppMsgData(content, EmptyString, kind, color, false, src));  

        [MethodImpl(Inline)]
        public static IAppMsg<C> message<C>(C content, string template, AppMsgKind kind, AppMsgColor color, AppMsgSource src)
            => new AppMsg<C>(new AppMsgData(content, template, kind, color, false, src));  
        
        public static IAppMsg<C> message<C>(C content, string template, AppMsgKind kind, AppMsgColor color, 
            [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => new AppMsg<C>(
                    new AppMsgData(content, template, kind, color, false, AppMsg.Source(Assembly.GetEntryAssembly().Id(), caller, file, line)));
    }
}