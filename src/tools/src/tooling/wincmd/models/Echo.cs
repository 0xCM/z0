//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    partial struct WinCmd
    {
        public enum EchoMode
        {
            Enable,

            Emit
        }

        public struct Echo : IToolCmd<Echo>
        {
            public bit On;

            public utf8 Message;

            public EchoMode Mode;
        }
    }
}