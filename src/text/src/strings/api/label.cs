//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Strings
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct strings
    {
        [MethodImpl(Inline)]
        public static Label label(ReadOnlySpan<char> src, int offset, StringBuffer dst)
        {
            var length = src.Length;
            if(length <= byte.MaxValue && store(src, offset, dst))
                return new Label(dst.Address(offset), (byte)length);
            else
                return Label.Empty;
        }

        [MethodImpl(Inline)]
        public static Label label(ReadOnlySpan<char> src, uint offset, StringBuffer dst)
        {
            var length = src.Length;
            if(length <= byte.MaxValue && store(src, offset, dst))
                return new Label(dst.Address(offset), (byte)length);
            else
                return Label.Empty;
        }
    }
}