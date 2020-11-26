//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRecord
    {

    }

    [Free]
    public interface IRecord<T> : IRecord
        where T : struct, IRecord<T>
    {

    }
}