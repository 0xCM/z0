//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using C = CmdSpec.robocopy;
    using R = CmdSpec.robocopy_response;
    using M = ProcessMessage;

    partial class CmdSpec
    {
        /// <summary>
        /// copies file data
        /// </summary>
        /// <remarks>
        /// See https://technet.microsoft.com/en-us/library/cc733145(v=ws.11).aspx
        /// </remarks>
        public sealed class robocopy : ProcessCommand<C,R>
        {         
            [InputArg(0)]
            public FolderPath source { get; set; }

            [InputArg(1)]
            public FolderPath target { get; set; }

            [InputFlag]
            public bool E { get; set; }

            public string[] XF { get; set; }

            public string[] XD { get; set; }

            public FilePath log { get; set; }

            public robocopy()
            {
                XF = z.array<string>();
                XD = z.array<string>();
                source = FolderPath.Empty;
                target = FolderPath.Empty;
                log = FilePath.Empty;
            }
            public robocopy(M content)
                : base(content)
            {
                XF = z.array<string>();
                XD = z.array<string>();
                source = FolderPath.Empty;
                target = FolderPath.Empty;
                log = FilePath.Empty;
            }

            public override R ok(M content)
                => new R(this, content);

            public override R error(M content)
                => new R(this, content);

            public override string Format()
            {
                var command = this;
                var msg = $"{command.source} {command.target}";
                if (command.E)
                    msg = text.concat(msg, Space, "/", nameof(command.E));

                if (command.XF.Length != 0)
                    msg = text.concat(msg, Space, "/", nameof(command.XF), Space, text.join(Space, command.XF));

                if (command.XD.Length != 0)
                    msg = text.concat(msg, Space, "/", nameof(command.XD), Space, text.join(Space, command.XD));

                if (z.not(log.IsEmpty))
                    msg = text.concat(msg, Space, "/tee /", nameof(command.log), "+:", $"{log}");

                return msg;
            }
        }
    }
}