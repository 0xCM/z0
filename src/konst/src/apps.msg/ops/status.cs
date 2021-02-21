//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class AppMsg
    {
        public static StatusMsg<T> status<T>(T data)
            => new StatusMsg<T>(data);
    }
}