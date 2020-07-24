//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDataEmitter
    {

    }
    
    public interface IDataEmitter<S,K> : IDataEmitter   
    {
        S StepKind {get;}

        K DataKind {get;}
    }
}