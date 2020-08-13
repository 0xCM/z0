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
        public static WfCaller caller(PartId part, string caller, FS.FilePath file, uint line)
            => new WfCaller(part,caller,file,line);

        [MethodImpl(Inline), Op]
        public static WfCaller caller(PartId part, [CallerMemberName] string caller = null, [CallerFilePath]string file = null, [CallerLineNumber] int? line = null)        
            => new WfCaller(part, caller, FS.path(file), line ?? 0);
    }
}