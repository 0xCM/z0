//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRngContext : IContextual<IPolyrand>
    {
        IPolyrand Random {get;}

        IPolyrand IContextual<IPolyrand>.Context
            => Random;
    }

    [Free]
    public interface IRngContext<C> : IRngContext
        where C : struct, IRngContext<C>
    {

    }
}