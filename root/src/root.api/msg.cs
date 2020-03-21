//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class Root
    {        
        public static AppMsg msg(object content, AppMsgKind level = AppMsgKind.Info)
            => level == AppMsgKind.Warning ? AppMsg.Define($"{content} (warning)",level) : AppMsg.Define($"{content}",level);

        public static AppMsg msg(Exception content)
            => AppMsg.Define(content.ToString(), AppMsgKind.Error);
        
        public static AppMsg msg(object content, AppMsgColor color)
            => AppMsg.Colorize(content, color);
    }
}