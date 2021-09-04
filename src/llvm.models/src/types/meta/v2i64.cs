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
        ///  2 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v2i64
        {
            public const ushort Width = 128;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v2i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(Identifier);
            }

            [MethodImpl(Inline)]
            public static ref TypeDescriptor describe(out TypeDescriptor dst)
            {
                var src = default(v2i64);
                dst.Name = src.Name;
                dst.Width = width(src);
                return ref dst;
            }
        }
    }
}