//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    partial struct RuleModels
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ByteSize encode<T>(in CmpPred<T> src, Span<byte> dst)
            where T : unmanaged
        {
            seek(dst,0) = (byte)src.Kind;
            var target = recover<T>(slice(dst,1));
            seek(target,0) = src.A;
            seek(target,1) = src.B;
            return size<T>()*2 + 1;
        }
    }
}