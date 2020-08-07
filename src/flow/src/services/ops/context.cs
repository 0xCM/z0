//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {
        [MethodImpl(Inline), Op]
        public static WfContext context(IAppContext root, in CorrelationToken ct, in WfSettings config, in WfTermEventSink sink)
            => new WfContext(root, ct, config, sink);   

        [MethodImpl(Inline), Op]
        public static AppMsgSource source([CallerMemberName] string caller = null, [CallerFilePath]string file = null, [CallerLineNumber] int? line = null, PartId? part = null)        
            => new AppMsgSource(part ?? PartId.None, caller, file, line);
    }
}