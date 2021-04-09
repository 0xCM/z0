//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmLang
    {
        public enum OpWidth : byte
        {
            None = 0,

            W8 = 1,

            W16 = 2,

            W32 = 3,

            W64 = 4,

            W128 = 5,

            W256 = 6,

            W512 = 7
        }
    }
}