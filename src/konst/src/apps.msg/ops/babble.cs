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
        [MethodImpl(Inline), Op]
        public static AppMsg babble(object content)
            => new AppMsg(content, LogLevel.Babble, FlairKind.Disposed, EmptyString, EmptyString, null);
    }
}