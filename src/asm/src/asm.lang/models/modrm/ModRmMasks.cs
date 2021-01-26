//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct ModRmMasks
    {
        public const byte ModIndex = 6;

        public const byte RegIndex = 2;

        public const byte RmIndex = 0;

        public const byte ModMask = 0b11000000;

        public const byte RegMask = 0b00111000;

        public const byte RmMask = 0b00000111;
    }
}