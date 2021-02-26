//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public sealed class MsgExchange : IMsgExchange
    {
        public event Action<IAppMsg> Next;

        /// <summary>
        /// Creates an exchange and underlying queue
        /// </summary>
        public static IMsgExchange Create(IWfShell wf)
            => new MsgExchange();

        MsgExchange()
        {
            Next = x => {};
        }
    }
}