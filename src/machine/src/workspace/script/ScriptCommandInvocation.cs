//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Encapsulates a <see cref="ScriptCommand"/> together with the arguments to supply when executing
    /// </summary>
    public class ScriptCommandInvocation
    {
        public readonly ScriptCommand Command;
        public readonly IReadOnlyList<object> Arguments;

        public ScriptCommandInvocation(ScriptCommand Command, object[] Arguments)
        {
            this.Command = Command;
            this.Arguments = Arguments;
        }

        public void Invoke(object host)
        {
            Command.Execute(host, Arguments.ToArray());
        }
    }
}