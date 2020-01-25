//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Z0.AsmSpecs;

    using static zfunc;

    public interface IAsmImmCapture
    {
        AsmFunction Capture(byte imm8);

        IEnumerable<AsmFunction> Capture(params byte[] immediates)
            => immediates.Select(Capture);

    }    

    public interface IAsmImmCapture<T> : IAsmImmCapture
        where T : unmanaged        
    {
    }

}