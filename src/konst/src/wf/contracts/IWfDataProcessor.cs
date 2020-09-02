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

    public interface IWfDataProcessor
    {
        void Connect() {}
    }

    public interface IWfDataProcessor<S> : IWfDataProcessor
    {

    }
}