//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    partial class CaptureWorkflowEvents
    {
        public readonly struct PurgedArchiveFolder : IAppEvent<PurgedArchiveFolder>
        {
            public readonly FolderPath Path;

            [MethodImpl(Inline)]
            public PurgedArchiveFolder(FolderPath path)
            {
                Path = path;
            }            
            
            public string Description
                => $"Purged archive content in {Path}";

            public PurgedArchiveFolder Zero 
                => Empty; 

            public static PurgedArchiveFolder Empty 
                => new PurgedArchiveFolder(FolderPath.Empty);
        }    
    }
}