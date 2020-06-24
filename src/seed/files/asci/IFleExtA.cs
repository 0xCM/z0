//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IFileExt<A> : IAsciContainer<A>
        where A : unmanaged, IAsciSequence
    {
        A Name {get;}

        A IContented<A>.Content
            => Name;
    }
}