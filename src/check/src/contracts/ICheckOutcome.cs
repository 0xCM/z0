//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Characterizes a boolean outcome
    /// </summary>
    public interface ICheckOutcome
    {
        bit Ok {get;}


        utf8 Reason {get;}
    }

    /// <summary>
    /// Characterizes a reified boolean outcome
    /// </summary>
    public interface ICheckOutcome<H> : ICheckOutcome
        where H : struct, ICheckOutcome<H>
    {

    }

    /// <summary>
    /// Characterizes a reified boolean outcome together with a parametric aspect
    /// </summary>
    public interface ICheckOutcome<H,A> : ICheckOutcome<H>
        where H : struct, ICheckOutcome<H,A>
    {
        ref A Get(out A src);

        ref A Set(in A src);
    }
}