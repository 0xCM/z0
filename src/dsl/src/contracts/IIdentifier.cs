//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dsl
{
    using System;

    public interface IIdentifier<H> : IName<string>, IEquatable<H>, IComparable<H>
        where H : struct, IIdentifier<H>
    {

    }
}