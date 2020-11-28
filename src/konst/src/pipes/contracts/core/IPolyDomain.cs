//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a fountain of generic points
    /// </summary>
    [Free]
    public interface IPolyDomain : IDomainValueSource, ISource
    {

    }
}