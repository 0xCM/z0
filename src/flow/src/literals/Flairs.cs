//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;

    [LiteralProvider]
    public readonly struct Flairs
    {
        public const AppMsgColor Error = AppMsgColor.Red;

        public const AppMsgColor Created = AppMsgColor.Gray;

        public const AppMsgColor Running = AppMsgColor.Magenta;

        public const AppMsgColor Ran = AppMsgColor.Cyan;

        public const AppMsgColor Finished = AppMsgColor.Gray;

        public const AppMsgColor Status = AppMsgColor.Green;

        public const AppMsgColor Initializing = AppMsgColor.Gray;

        public const AppMsgColor Initialized = AppMsgColor.Gray;
    }
}