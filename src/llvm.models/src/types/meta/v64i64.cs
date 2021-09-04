//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial struct Metatypes
    {
        /// <summary>
        ///  64 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v64i64
        {
            public const ushort Width = 4096;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v64i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(Identifier);
            }
        }
    }
}