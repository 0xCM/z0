//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class AppMsg<T> : AppMsg, IAppMsg<T>
    {
        public AppMsg(AppMsgData content)
            : base(content)
        { }


        public new T Content 
            => (T)base.Content;
    }
}