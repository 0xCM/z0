//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CapturedApiRes
    {
        public ApiHostUri ApiHost {get;}

        public ApiMemberRes Accessor {get;}

        public AsmRoutineCode Code {get;}

        [MethodImpl(Inline)]
        public CapturedApiRes(ApiHostUri host, in ApiMemberRes accessor, in AsmRoutineCode code)
        {
            ApiHost = host;
            Accessor = accessor;
            Code = code;
        }
    }
}