//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public struct TextProcessorSettings
    {
        public uint StatusFrequency;

        public uint LineBufferSize;

        public static ref TextProcessorSettings Default(out TextProcessorSettings dst)
        {
            dst.StatusFrequency = Pow2.T17;
            dst.LineBufferSize = 1024;
            return ref dst;
        }
    }
}