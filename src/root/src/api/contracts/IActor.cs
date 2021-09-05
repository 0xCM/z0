//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IActor
    {
        string Name {get;}
    }

    public interface IActor<S,T> : IActor
    {
        S Source {get;}

        T Target {get;}
    }
}