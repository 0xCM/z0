//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    partial struct AsmCodes
    {
        /// <summary>
        /// Classfies vex prefix codes
        /// </summary>
        public enum VexPrefiKind : byte
        {
            [Symbol("xC5", "The leading byte of a 2-byte vex prefix sequence")]
            xC5 = 0xc5,

            [Symbol("xC4", "The leading byte of a 3-byte vex prefix sequence")]
            xC4 = 0xc4,
        }
    }
}