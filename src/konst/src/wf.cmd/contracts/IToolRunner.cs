//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IToolRunner : IWfService
    {
        Outcome<TextLines> Run(CmdLine cmd);

        Outcome<TextLines> RunCmdScript<K>(K kind, Name name);

        Outcome<TextLines> RunPsScript<K>(K kind, Name name);
    }
}