//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IReactor
    {
        void Dispatch(CmdLine cmd);

        void ShowSupported();

        IndexedView<CmdId> SupportedCommands();
    }
}