//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct AsciResources<A> : IAsciResources<A>
        where A : IAsciSequence
    {
        public string Name {get;}

        public AsciResource<A>[] Content {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public AsciResources(string name, AsciResource<A>[] content, string description = text.Empty)
        {
            Name = name;
            Content = content;
            Description = description;
        }
    }
}