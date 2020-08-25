//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IMachineEngine : IMachineClient, IDisposable
    {
        void Run();
    }

    public interface IMachineEngine<H> : IMachineEngine
        where H : IMachineEngine<H>
    {}
}