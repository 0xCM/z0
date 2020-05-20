//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct AsmPublication
    {
        [MethodImpl(Inline)]
        public static AsmPublication<R> Flow<R>(R[] src, FilePath dst)
            where R : ITabular
                => new AsmPublication<R>(src,dst);
    }
    
    public readonly struct AsmPublication<R> : IDataFlow<R[],FilePath>
        where R : ITabular
    {
        public readonly R[] Source {get;}

        public FilePath Target {get;}
        
        [MethodImpl(Inline)]
        public AsmPublication(R[] src, FilePath dst)
        {
            Source = src;
            Target = dst;
        }
    }
}