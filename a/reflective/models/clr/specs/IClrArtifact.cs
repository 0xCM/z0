//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IClrArtifact : IArtifactModel
    {        
        
    }

    public interface IClrArtifact<T> : IClrArtifact
    {
        T Subject {get;}    
    }
}