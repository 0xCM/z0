//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    partial struct Part
    {
        /// <summary>
        /// Computes the type width of a parametrically-identified type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static DataWidth width<W>(W w = default)
            where W : unmanaged, IDataWidth<W>
                => w.DataWidth;

        public static W1 w1 => default;

        public static W2 w2 => default;

        public static W3 w3 => default;

        public static W4 w4 => default;

        public static W5 w5 => default;

        public static W6 w6 => default;

        public static W7 w7 => default;

        public static W8 w8 => default;

        public static W8i w8i => default;

        public static W16 w16 => default;

        public static W16i w16i => default;

        public static W32 w32 => default;

        public static W32i w32i => default;

        public static W40 w40 => default;

        public static W64 w64 => default;

        public static W64i w64i => default;

        public static W128 w128 => default;

        public static W128i w128i => default;

        public static W256 w256 => default;

        public static W256i w256i => default;

        public static W512 w512 => default;

        public static W512i w512i => default;

        public static W1024 w1024 => default;
    }
}