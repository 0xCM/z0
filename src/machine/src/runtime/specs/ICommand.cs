//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;

    public interface ICommand
    {
        ReadOnlySpan<byte> Encoded {get;}
    }

    public interface ICommand<F> : ICommand
        where F: unmanaged, ICommand<F>
    {

    }

}