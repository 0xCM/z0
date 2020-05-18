//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    public class AsmDataModels
    {
        public readonly struct OpCodes
        {
            public string Name => nameof(OpCodes);

            public static OpCodes Model => default(OpCodes);            
        }

        public readonly struct Instructions
        {
            public string Name => nameof(Instructions);

            public static Instructions Model => default(Instructions);

        }

        public readonly struct DecoderTests
        {
            public string Name => nameof(DecoderTests);

            public static DecoderTests Model => default(DecoderTests);
        }

    }
}