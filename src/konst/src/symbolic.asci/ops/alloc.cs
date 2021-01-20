//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Asci
    {
        [MethodImpl(Inline), Op]
        public static asci16[] alloc(N16 n, int count)
        {
            var buffer =  new asci16[count];
            Span<asci16> dst = buffer;
            dst.Fill(Asci.init(n));
            return buffer;
        }
    }
}