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

    public interface ICommandM
    {
        /// <summary>
        /// The encoded command
        /// </summary>
        ReadOnlySpan<byte> Encoded {get;}
    }

    public interface ICommandM<F> : ICommandM
        where F: unmanaged, ICommandM<F>
    {

    }

}