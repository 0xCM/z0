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
        where A : IBytes
    {
        public asci32 Name {get;}

        public A Content {get;}

        public asci64 Description {get;}

        [MethodImpl(Inline)]
        public AsciResource(asci32 name, A content, asci64? description = null)
        {
            Name = name;
            Content = content;
            Description = description ?? asci64.Null;
        }
    }
}