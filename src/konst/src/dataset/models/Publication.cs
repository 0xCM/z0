//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Publication<R>
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