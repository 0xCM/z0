//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IClrArtifact
    {        
        
    }

    public interface IClrArtifact<T> : IClrArtifact
    {
        T Metadata {get;}    
    }
}