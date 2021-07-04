//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    partial struct AsmCodes
    {
        [SymSource]
        public enum SizeKeyword : byte
        {
            /// <summary>
            /// 8 bits
            /// </summary>
            [Symbol("byte")]
            @byte,

            /// <summary>
            /// 16 bits
            /// </summary>
            [Symbol("word")]
            word,

            /// <summary>
            /// 32 bits
            /// </summary>
            [Symbol("dword")]
            dword,

            /// <summary>
            /// 64 bits
            /// </summary>
            [Symbol("qword")]
            qword,

            /// <summary>
            /// 128 bits - also known as a "Double Quadword"
            /// </summary>
            [Symbol("xmmword")]
            xmmword,

            /// <summary>
            /// 256 bits
            /// </summary>
            [Symbol("ymmword")]
            ymmword,

            /// <summary>
            /// 512 bits
            /// </summary>
            [Symbol("zmmword")]
            zmmword,
        }
    }
}