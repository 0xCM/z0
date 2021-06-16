//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [ApiComplete]
    public readonly struct AsmKeywords
    {
        public static string @byte() => "byte";

        public static string word() => "word";

        public static string dword() => "dword";

        public static string qword() => "qword";

        public static string xmmword() => "xmmword";

        public static string ymmword() => "ymmword";

        public static string zmmword() => "ymmword";

        public static string ip() => "ip";

        public static string eip() => "eip";

        public static string rip() => "rip";

        public static string ptr() => "ptr";

        public static ReadOnlySpan<char> Sizes => "word\0dword\0qword\0xmmword\0ymmword\0zmmword";

        [SymbolSource]
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

        /// <summary>
        /// Specifies instruction pointer registers
        /// </summary>
        [SymbolSource]
        public enum IpReg : byte
        {
            [Symbol("ip")]
            IP,

            [Symbol("eip")]
            EIP,

            [Symbol("rip")]
            RIP,
        }
    }
}