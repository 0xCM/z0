//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using c = CmdSpec.mklink;
    using r = CmdSpec.mklink_response;
    using m = ProcessMessage;

    partial class CmdSpec
    {
        /// <summary>
        /// Creates a symbolic link
        /// </summary>
        /// <remarks>
        /// See https://technet.microsoft.com/en-us/library/cc753194(v=ws.11).aspx
        /// </remarks>
        [CmdPrototype(Prototype)]
        public sealed class mklink : ProcessCommand<c,r>
        {
            public const string Prototype = "mklink [[/d] | [/h] | [/j]] <Link> <Target>";

            public static PromptInputSyntax syntax
                => DefineSyntax().WithFlags(nameof(d), nameof(h), nameof(j)).WithPositionalParameters(nameof(Link), nameof(Target));

            [InputFlag]
            public bool d {get; set;}

            [InputFlag]
            public bool h {get; set;}

            [InputFlag]
            public bool j {get; set;}

            [InputArg(0)]
            public string Link {get; set;}

            [InputArg(1)]
            public string Target { get; set;}

            public mklink()
            { 

            }

            internal mklink(m content)
                : base(content)
            { }

            public override r ok(m content)
                => new r(this, content);

            public override r error(m content)
                => new r(this, content);                       
        }

        public class mklink_response : ProcessComandResponse<r, c>
        {
            internal mklink_response(c command, m content)
                : base(command, content)
            { }
        }
    }

    partial class CmdExec
    {
        public static c mklink(this IProcess broker, c parameters = default(c))
            => broker.Submit<c>(parameters);
    }
}