//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Publication
    {
        [MethodImpl(Inline)]
        public static Publication<R> Flow<R>(R[] src, FilePath dst)
            where R : ITabular
                => new Publication<R>(src,dst);
    }
    
    public readonly struct Publication<R> : IDataFlow<R[],FilePath>
        where R : ITabular
    {
        public readonly R[] Source {get;}

        public FilePath Target {get;}
        
        [MethodImpl(Inline)]
        public Publication(R[] src, FilePath dst)
        {
            Source = src;
            Target = dst;
        }
    }
}