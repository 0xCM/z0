//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IBijection<S,T> : ICounted<Count>
    {
        Pairings<S,T> Terms {get;}

        Count ICounted<Count>.Value
            => Terms.Count;
    }
}