//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        public static void ThrowEmptySpanError()
            => throw new Exception($"The span is empty");

        [MethodImpl(NotInline), Op]
        public static void @throw(string msg)
            => throw new Exception(msg);

        [MethodImpl(NotInline), Op]
        public static void @throw(Exception e)
            => throw e;
    }
}