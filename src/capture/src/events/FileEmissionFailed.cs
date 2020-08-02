//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct FileEmissionFailed : IWfEvent<FileEmissionFailed>
    {
        public WfEventId Id  => WfEventId.define("Placeholder");

        public readonly ApiHostUri Host;

        public readonly bool Generic;

        public readonly FilePath TargetFile;

        [MethodImpl(Inline)]
        public static FileEmissionFailed Define(ApiHostUri host, bool generic, FilePath dst)
            => new FileEmissionFailed(host,generic, dst);

        [MethodImpl(Inline)]
        internal FileEmissionFailed(ApiHostUri uri, bool generic, FilePath dst)
        {
            Host = uri;
            Generic = generic;
            TargetFile = dst;
        }

        public AppMsgColor Flair
            => AppMsgColor.Red;                    
        
        public string Format()
            => $"{Host} emission failure" + (Generic ? " (generic)" : string.Empty) + TargetFile.FullPath;
        
        public FileEmissionFailed Zero 
            => Empty;

        public static FileEmissionFailed Empty 
            => new FileEmissionFailed(ApiHostUri.Empty,false, FilePath.Empty);
    }            
}