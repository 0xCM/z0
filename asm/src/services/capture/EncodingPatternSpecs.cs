//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using static zfunc;

    using static Z0.EncodingPatternTokens;
        
    public readonly struct EncodingPatternSpecs
    {

        readonly struct RET_SBB 
        {            
            public ReadOnlySpan<byte> PatternData
                => new byte[]{RET, SBB};
        }

        readonly struct RET_INTR
        {
            public ReadOnlySpan<byte> PatternData
                => new byte[]{RET,INTR};
        }

        readonly struct RET_ZED_SBB
        {
            public ReadOnlySpan<byte> PatternData
                => new byte[]{RET,ZED,SBB};
        }

        readonly struct RET_Zx2
        {
            public ReadOnlySpan<byte> PatternData
                => new byte[]{RET,ZED,ZED};
        }

        readonly struct INTRx2
        {
            public ReadOnlySpan<byte> PatternData
                => new byte[]{INTR,INTR};
        }

        readonly struct JMP_RAX
        {
            public ReadOnlySpan<byte> PatternData
                => new byte[]{ZED,ZED,J48,FF,E0};
        }

        readonly struct Zx7
        {
            public ReadOnlySpan<byte> PatternData
                => new byte[]{ZED,ZED,ZED,ZED,ZED,ZED,ZED};
        }

        readonly struct CALL32_INTR
        {

            public ReadOnlySpan<byte?> PatternData
                => new byte?[]{CALL,null,null,null,null,INTR};            
        }

 
    }
}