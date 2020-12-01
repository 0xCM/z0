//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICorrelated
    {
        CorrelationToken Ct
            => CorrelationToken.Empty;
    }

    [Free]
    public interface ICorrelated<F> : ICorrelated
        where F : struct, ICorrelated
    {

    }
}