//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    public interface IAsmDataModel
    {   
        string Name {get;}
    }
    
    public class AsmDataModels
    {
        public readonly struct OpCodeForms : IAsmDataModel
        {
            public string Name => nameof(OpCodeForms);

            public static OpCodeForms Model => default(OpCodeForms);            
        }

        public readonly struct Instructions : IAsmDataModel
        {
            public string Name => nameof(Instructions);

            public static Instructions Model => default(Instructions);
        }

        public readonly struct OperandCounts : IAsmDataModel
        {
            public string Name => nameof(OperandCounts);

            public static OperandCounts Model => default(OperandCounts);
        }

        public readonly struct DecoderTests : IAsmDataModel
        {
            public string Name => nameof(DecoderTests);

            public static DecoderTests Model => default(DecoderTests);
        }
    }
}