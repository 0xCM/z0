//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    [ApiHost]
    public readonly struct ModRmEncoder : IApiHost<ModRmEncoder>
    {
        public static ModRmEncoder Service => default(ModRmEncoder);

        internal const byte RmIndex = 0;

        internal const byte RegIndex = 2;

        internal const byte ModIndex = 6;

        internal const byte RmMask = 0b00000111;

        internal const byte RegMask = 0b00111000;

        internal const byte ModMask = 0b11000000;
    }
}