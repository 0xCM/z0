//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a tool option
    /// </summary>
    [Free]
    public interface IToolOption : INamed, ITextual
    {

    }

    /// <summary>
    /// Characterizes a kinded tool option
    /// </summary>
    [Free]
    public interface IToolOption<K> : IToolOption
        where K : unmanaged
    {
        K Kind {get;}

        string INamed.Name
            => Kind.ToString();
    }
}