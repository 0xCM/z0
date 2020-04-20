//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    public interface IExecutablePart : IExecutable, IPart
    {

    }
    
    public interface IExecutablePart<P> : IExecutablePart, IPart<P>
        where P : IPart<P>, new()
    {

    }
}