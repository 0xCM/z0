//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    public interface IFunctionAnalyzer<R> : IAnalyzer<FunctionAnalyzer<R>, AsmFunction, R>
        where R : IAnalysis
    {

    }

}