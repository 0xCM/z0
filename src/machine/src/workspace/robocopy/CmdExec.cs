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
}