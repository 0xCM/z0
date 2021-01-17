//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ICmdLineRunner
    {
        void Run(CmdLine src);
    }

    public interface IReactor : ICmdLineRunner
    {
        void Dispatch(CmdLine cmd);

        void ShowSupported();

        ReadOnlySpan<CmdId> SupportedCommands();
    }
}