//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CapturedApiResource
    {
        public ApiHostUri ApiHost {get;}

        public ApiResource Accessor {get;}

        public AsmRoutineCode Code {get;}

        [MethodImpl(Inline)]
        public CapturedApiResource(ApiHostUri host, in ApiResource accessor, in AsmRoutineCode code)
        {
            ApiHost = host;
            Accessor = accessor;
            Code = code;
        }
    }
}