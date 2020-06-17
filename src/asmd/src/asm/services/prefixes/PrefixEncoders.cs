//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        

    public readonly struct PrefixEncoders
    {
        public static ModRmEncoder ModRm => ModRmEncoder.Service;
    }
}