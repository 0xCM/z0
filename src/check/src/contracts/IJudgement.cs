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
    public interface IJudgement
    {
        bit Result {get;}
    }

    public interface IBinaryJudgement<T> : IJudgement
    {
        T A {get;}

        T B {get;}
    }

    /// <summary>
    /// Characterizes a reified boolean outcome
    /// </summary>
    public interface ISequenceJudgement<H,T> : IJudgement, ISpanBuffer<T>
        where H : struct, ISequenceJudgement<H,T>
    {

    }
}