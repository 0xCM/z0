//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IType
    {
        string Name  => "";
    }

    public interface IType<T> : IType
        where T : IType<T>, new()
    {

    }
}