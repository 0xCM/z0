//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Tool<T,F> : ITool<T,F>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {
        public ToolId ToolId {get;}

        public FolderPath SourceDir {get;}
        
        public FolderPath TargetDir {get;}

        public IExtensionMap<F> Map {get;}
        
        public IToolArchive<T,F> Target {get;}

        public ToolFlags<F> Flags {get;}
        
        [MethodImpl(Inline)]
        public Tool(ToolId id, FolderPath src, FolderPath dst)
        {
            ToolId = id;                        
            SourceDir = src;            
            TargetDir = dst;
            Flags = new ToolFlags<F>(0);            
            Map = new ExtensionMap<F>(0);
            Target = new ToolArchive<T,F>(id, TargetDir);
        }    


        public void Dispose()
        {

            
        }    
    }
}