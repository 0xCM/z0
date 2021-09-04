//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static Values;

    partial struct Metatypes
    {
        /// <summary>
        ///  4 x i64 vector value
        /// </summary>
        [StructLayout(Layout, Size = Size)]
        public struct v4i64
        {
            public const ushort Width = 256;

            public const ushort Size = Width/8;

            public const string Identifier = nameof(v4i64);

            public StringAddress Name
            {
                [MethodImpl(Inline)]
                get => name(Identifier);
            }

            [MethodImpl(Inline)]
            public static ref TypeDescriptor describe(out TypeDescriptor dst)
            {
                var src = default(v4i64);
                dst.Name = src.Name;
                dst.Width = width(src);
                return ref dst;
            }

        }
    }
}