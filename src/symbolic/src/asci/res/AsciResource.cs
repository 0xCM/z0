//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct AsciResource<A> : IAsciResource<A>
        where A : IAsciSequence
    {
        public string Name {get;}

        public A Content {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public AsciResource(string name, A content, string description = text.Empty)
        {
            Name = name;
            Content = content;
            Description = description;
        }
    }
}