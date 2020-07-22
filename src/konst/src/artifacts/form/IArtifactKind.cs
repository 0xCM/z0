//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    using static Konst;

    public interface IArtifactKind
    {
        ArtifactClass Class {get;}
    }
    
    public interface IArtifactKind<K> : IArtifactKind
        where K : unmanaged, Enum
    {
        K Kind {get;}
    }

    public interface IArtifactKind<F,K> : IArtifactKind<K>
        where F : unmanaged, IArtifactKind<F,K>
        where K : unmanaged, Enum
    {

    } 
}