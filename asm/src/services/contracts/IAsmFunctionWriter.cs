//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static zfunc;

    using Z0.AsmSpecs;

    public interface IAsmFunctionWriter : IAsmServiceAllocation
    {
        void Write(AsmFunction src);

    }
}