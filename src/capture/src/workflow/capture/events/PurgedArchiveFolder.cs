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
        public readonly FolderPath Path;

        [MethodImpl(Inline)]
        public ClearedDirectory(FolderPath path)
        {
            Path = path;
        }            
        
        public string Description
            => $"Purged content in {Path}";

        public ClearedDirectory Zero 
            => Empty; 

        public static ClearedDirectory Empty 
            => new ClearedDirectory(FolderPath.Empty);
    }    
}