//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IArtifactModel
    {
        string Name {get;}
    }

    public interface IArtifactModel<T> : IArtifactModel
    {

    }
    
    public interface IGenericArtifact<T> : IClrArtifact
    {        
        GenericState Kind {get;}
    }
}