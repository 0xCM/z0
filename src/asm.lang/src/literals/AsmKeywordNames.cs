//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public readonly struct AsmKeywordNames
    {
        /// <summary>
        /// 8 bits
        /// </summary>
        public const string Byte = "byte";

        /// <summary>
        /// 16 bits
        /// </summary>
        public const string Word = "word";

        /// <summary>
        /// 32 bits
        /// </summary>
        public const string DWord = "dword";

        /// <summary>
        /// 64 bits
        /// </summary>
        public const string QWord = "qword";

        /// <summary>
        /// 128 bits - also known as a "Double Quadword"
        /// </summary>
        public const string XmmWord = "xmmword";

        /// <summary>
        /// 256 bits
        /// </summary>
        public const string YmmWord = "ymmword";

        /// <summary>
        /// 512 bits
        /// </summary>
        public const string ZmmWord = "zmmword";
    }
}