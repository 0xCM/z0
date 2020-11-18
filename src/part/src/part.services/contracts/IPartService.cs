//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IPartService
    {

    }

    public interface IPartService<H> : IPartService
        where H : IPartService<H>, new()
    {

    }
}