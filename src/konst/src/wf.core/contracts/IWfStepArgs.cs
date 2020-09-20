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

    public interface IWfStepArgs
    {

    }

    public interface IWfStepArgs<H,T> : IWfStepArgs
        where H : struct, IWfStepArgs<H,T>
        where T : ITextual
    {

    }

}