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

    partial struct LlvmTypes
    {
        /// <summary>
        ///  1 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v1i64
        {
            public const ushort Width = 64;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v1i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(nameof(Identifier));
            }
        }
    }
}