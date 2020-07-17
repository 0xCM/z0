//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

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

    public readonly struct ArtifactKind
    {
        public readonly ArtifactClass Class;
    }

    public readonly struct ArtifactKind<K>
        where K : unmanaged
    {

    }

    public readonly struct ArtifactKind<F,T>
    {
        
    }    
}