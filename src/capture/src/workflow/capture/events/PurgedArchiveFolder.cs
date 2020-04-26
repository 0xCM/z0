//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    using E = AsmEvents.PurgedArchiveFolder;

    partial class AsmEvents
    {
        public readonly struct PurgedArchiveFolder : IAppEvent<E>
        {
            public static E Empty => new E(new FolderPath{});

            [MethodImpl(Inline)]
            public static E Define(FolderPath path)
                => new E(path);

            [MethodImpl(Inline)]
            PurgedArchiveFolder(FolderPath path)
            {
                Path = path;
            }            
            
            public FolderPath Path {get;}

            public string Description
                => $"Purged archive content in {Path}";

            public E Zero => Empty; 
        }    
    }
}