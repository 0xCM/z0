//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct ClearedDirectory : IAppEvent<ClearedDirectory>
    {
        const string MessagePattern = "Purged content in {0}";        
        
        public readonly FolderPath Path;

        [MethodImpl(Inline)]
        public ClearedDirectory(FolderPath path)
            => Path = path;
        
        public string Description
            => text.format(MessagePattern, Path);

        public ClearedDirectory Zero 
            => Empty; 

        public static ClearedDirectory Empty 
            => new ClearedDirectory(FolderPath.Empty);
    }    
}