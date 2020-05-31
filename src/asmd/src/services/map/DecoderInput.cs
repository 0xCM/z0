//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class HexMapper
    {
        public readonly struct DecoderInput
        {
            [MethodImpl(Inline)]
            public DecoderInput(byte[] src) 
            {
                this.Data = src;
            }
            
            public readonly byte[] Data;
        }
    }    
}