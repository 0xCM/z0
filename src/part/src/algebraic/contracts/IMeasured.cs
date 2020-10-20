//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a type that exhibits a notion of finite length
    /// </summary>
    [Free]
    public interface IMeasured : ICounted
    {
        int Length {get;}

        uint ICounted.Count
            => (uint)Length;
    }

    /// <summary>
    /// Characterizes a reified type that  exhibits a notion of length
    /// </summary>
    [Free]
    public interface IMeasured<S> : IMeasured
        where S : IMeasured<S>, new()
    {

    }
}