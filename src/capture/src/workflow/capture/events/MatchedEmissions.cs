//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using E = MatchedCapturedEmissions;

    public readonly struct MatchedCapturedEmissions : IAppEvent<E>
    {
        public readonly ApiHostUri Host;
        
        public readonly int Count;

        public readonly FilePath TargetPath;

        [MethodImpl(Inline)]
        public static E Define(ApiHostUri host, int count, FilePath path)
            => new E(host,count,path);
        
        [MethodImpl(Inline)]
        public MatchedCapturedEmissions(ApiHostUri host, int count, FilePath path)
        {
            Host = host;
            Count = count;
            TargetPath = path;              
        }
        
        public string Format()
            => $"{Count} {Host} members in memory were matched with emissions written to {TargetPath}";
        
        public E Zero 
            => Empty;

        public static E Empty 
            => new MatchedCapturedEmissions(ApiHostUri.Empty, 0, FilePath.Empty);
    }    
}