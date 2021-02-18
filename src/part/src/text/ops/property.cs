//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class text
    {
        [MethodImpl(Inline)]
        public static PropertyFormat<T> property<T>(string name, T value, sbyte pad = RP.PropertyPad)
            => new PropertyFormat<T>(name, value, pad);
    }
}