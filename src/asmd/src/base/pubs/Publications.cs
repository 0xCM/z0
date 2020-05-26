//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Publications
    {
        public static Publishers Publishers => default;                

        public static IPublicationArchive Archive 
            => PublicationArchive.Default;

        [MethodImpl(Inline)]
        public static Publication<R> Flow<R>(R[] src, FilePath dst)
            where R : ITabular
                => new Publication<R>(src,dst);
    }   
}