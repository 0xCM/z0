//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;

    public class IntelDocs : AppService<IntelDocs>
    {


    }


    public readonly partial struct IntelSdm
    {
        [MethodImpl(Inline)]
        public static TableNumber table(byte major, byte minor)
            => new TableNumber(major,minor);

        [MethodImpl(Inline)]
        public static Outcome table(string src, out TableNumber dst)
            => TableNumber.parse(src, out dst);
    }
}