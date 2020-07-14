//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class AppMsg<T> : AppMsg, IAppMsg<T>
    {
        internal AppMsg(AppMsgData content)
            : base(content)
        { }

        T IAppMsg<T>.Content
            => (T)(this as IAppMsg).Content;
    }
}