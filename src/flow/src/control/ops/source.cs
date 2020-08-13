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
        public static AppMsgSource source(PartId part, [CallerMemberName] string caller = null, [CallerFilePath]string file = null, [CallerLineNumber] int? line = null)        
            => new AppMsgSource(part, caller, file, line);
    }
}