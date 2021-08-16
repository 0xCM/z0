//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    using static LlvmValues;

    public readonly partial struct LlvmTypes
    {
        /// <summary>
        ///  256 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v256i64
        {
            public const ushort Width = 16384;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v256i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
       }
    }
}