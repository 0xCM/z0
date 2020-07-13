//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IMessagePrinter
    {
        void Print(IAppMsg message)
            => Terminal.Get().WriteMessage(message);
    }
}