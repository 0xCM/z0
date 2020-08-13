//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
        
    public struct ToolConfig : IToolConfig
    {
        public ToolId ToolId {get;}

        public FilePath Source {get;}
    
        [MethodImpl(Inline)]
        public ToolConfig(ToolId tool, FilePath src)
        {
            Source = src;
            ToolId = tool;
        }
    }   
}
