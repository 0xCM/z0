//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{

    public readonly struct AsmSyntaxSymbols
    {
        /// <summary>
        /// 8 bits
        /// </summary>
        public const string @byte = "byte";

        /// <summary>
        /// 16 bits
        /// </summary>
        public const string word = "word";

        /// <summary>
        /// 32 bits
        /// </summary>
        public const string dword = "dword";

        /// <summary>
        /// 64 bits
        /// </summary>
        public const string qword = "qword";

        /// <summary>
        /// 128 bits - also known as a "Double Quadword"
        /// </summary>
        public const string xmmword = "xmmword";

        /// <summary>
        /// 256 bits
        /// </summary>
        public const string ymmword = "ymmword";

        /// <summary>
        /// 512 bits
        /// </summary>
        public const string zmmword = "zmmword";
    }
}