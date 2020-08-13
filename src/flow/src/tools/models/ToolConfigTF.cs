//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public struct ToolPath<T,F> 
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {
        public ToolId ToolId {get;}

        public FS.FilePath Source {get;}
        
        [MethodImpl(Inline)]
        public ToolPath(ToolId tool, string src)
        {
            Source = new FS.FilePath(src);
            ToolId = tool;
        }
    }   
}
