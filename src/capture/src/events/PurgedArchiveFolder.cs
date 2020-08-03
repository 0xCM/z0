//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
    
    public readonly struct ClearedDirectory : IWfEvent<ClearedDirectory>
    {
        public WfEventId Id  => WfEventId.define("Placeholder");

        const string MessagePattern = "Purged content in {0}";        
        
        public readonly FolderPath Path;

        [MethodImpl(Inline)]
        public ClearedDirectory(FolderPath path)
            => Path = path;
        
        public string Format()
            => text.format(MessagePattern, Path);

        public ClearedDirectory Zero 
            => Empty; 

        public static ClearedDirectory Empty 
            => new ClearedDirectory(FolderPath.Empty);
    }    
}