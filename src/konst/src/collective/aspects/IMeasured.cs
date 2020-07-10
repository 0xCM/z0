//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    /// <summary>
    /// Characterizes a type that exhibits a notion of finite length
    /// </summary>
    public interface IMeasured : ICounted
    {
        int Length {get;}

        int ICounted.Count 
            => Length;
    }

    /// <summary>
    /// Characterizes a refiied type that  exhibits a notion of length
    /// </summary>
    public interface IMeasured<S> : IMeasured, IReified<S>
        where S : IMeasured<S>, new()
    {

    }
}