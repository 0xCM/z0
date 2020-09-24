//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class IXTend
    {
       [Op]
       public static string Format(this ApiUriScheme src)
            => src.ToString().ToLower();
    }
}