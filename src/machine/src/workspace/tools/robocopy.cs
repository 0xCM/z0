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
    using S = RobocopySpec;
    using X = RobocopyExec;


    [CommandSpec]
    public class RobocopySpec : ProcessCommandSpec<S,C,R>
    {
        readonly C Command;
        
        public RobocopySpec()
        {

        }

        public RobocopySpec(C src)
            : base(src)
        {
            Command = src;
        }
    }
    
    partial class CmdExec
    {        
        public static C robocopy(this IProcess broker, params string[] args)
            => broker.Submit<C>(args);

        public static C robocopy(this IProcess broker, S spec)
            => broker.Submit<C>(spec.Format());

        public static C help(this C command)
            => command.SubmittingProcess.robocopy("/?");
    }

    [CommandPattern]
    public class RobocopyExec : CommandExecutionService<X,S,R>
    {        
        readonly IAppContext Context;
        
        void OnError(MessagePacket packet)
        {
            term.error(packet.Payload);
        }

        void OnStandard(MessagePacket packet)
        {
            term.print(packet.Payload);
        }

        IMessage Inspect(IMessage message)
        {
            term.print(message);
            return message;
        }

        public RobocopyExec(IAppContext context)
        {
            Context = context;            
        }

        public Option<R> TryExecute(S spec)
        {
            try
            {
                var process = ProcessAdapter.ExecuteCmd(OnStandard, OnError, Inspect);
                var c = process.robocopy(spec);
                return new R(c, c.content);
            }
            catch(Exception e)
            {
                term.print(e);
                return Option.none<R>();
            }
        }
    }    

    partial class CmdSpec
    {

        public class robocopy_response : ProcessComandResponse<R, C>
        {
            internal robocopy_response(C command, M content)
                : base(command, content)
            { }
        }
                        
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