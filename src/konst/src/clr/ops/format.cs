//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using Msil;

    using static Part;

    partial struct Clr
    {
        [Op]
        public static string format(CliSig src)
            => DefaultCilFormatProvider.Instance.SigByteArrayToString(src);
    }
}