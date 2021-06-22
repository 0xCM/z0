//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class CmdDispatcher : ICmdDispatcher
    {
        CmdRunnerLookup Lookup;

        object Host;

        internal CmdDispatcher(object host, CmdRunnerLookup lookup)
        {
            Host = host;
            Lookup = lookup;
        }

        public ReadOnlySpan<string> Supported
            => Lookup.Specs;

        public Outcome Dispatch(string command, CmdArgs args)
        {
            try
            {
                if(Lookup.Find(command, out var method))
                    return (Outcome)method.Invoke(Host, new object[1]{args});
                else
                    return (false, string.Format("Command '{0}' unrecognized", command));
            }
            catch(Exception e)
            {
                return e;
            }
        }

        public Outcome Dispatch(string command)
            => Dispatch(command, CmdArgs.Empty);
    }
}