//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface IArtifactReceiver<K>
        where K : unmanaged
    {
        void Accept(Artifact<K> src);
    }

    public interface IArtifactEmitter<K>
        where K : unmanaged
    {
        Artifact<K> Emit();
    }

    public interface IArtifactFlow<A,B>
        where A : unmanaged
        where B : unmanaged
    {
        Outcome Process(in Artifact<A> src, out Artifact<B> dst);
    }
}