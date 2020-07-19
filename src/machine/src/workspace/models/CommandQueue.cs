//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static z;

    public class CommandCompletion : CommandDispatch, ICommandCompletion
    {
        readonly DateTime Timestamp;

        public ICommandResult Result { get; }

        public static CommandCompletion<S> Create<S>(CommandDispatch<S> src, CommandResult<S> result, DateTime? ts = null)
            where S : CommandSpec<S>, new()
                    => new CommandCompletion<S>(src, result, ts);

        public static CommandCompletion<S,P> Create<S,P>(CommandDispatch<S> src, CommandResult<S,P> result, DateTime? ts = null)
            where S : CommandSpec<S,P>, new()
                    => new CommandCompletion<S,P>(src, result, ts);

        public CommandCompletion(ICommandDispatch src, ICommandResult result, DateTime? ts = null)
            : base(src)
        {
            Timestamp = ts ?? now();
            Result = result;
        }

        public DateTime CompleteTime
            => Timestamp;

        public bool Succeeded
            => Result.Succeeded;

        public string CompleteMessage
            => Result.Message.Format();


        public override CommandExecutionStatus Status
            => CommandExecutionStatus.Completed;

    }

    /// <summary>
    /// Implements a command queue via the <see cref="ICommandExecStore"/> service
    /// </summary>
    /// <typeparam name="S"></typeparam>
    public sealed class CommandQueue<S> : ICommandQueue<S> //ApplicationService<CommandQueue<TSpec>, ICommandQueue<TSpec>>, 
        where S : CommandSpec<S>, new()
    {
        ICommandExecStore ExecStore { get; }
                
        public CommandQueue(IAppContext context)
        {
            ExecStore = context.CommandExecStore();
        }

        Option<CommandSubmission[]> ICommandQueue.Enqueue(IEnumerable<ICommandSpec> commands, SystemNode target, CorrelationToken? ct)
            => Enqueue(commands.Cast<S>(), target,  ct)
                    .Select(x => 
                            x.Map(y => new CommandSubmission(y.Spec, y.SubmissionId, y.CommandJson, y.CorrelationToken, y.EnqueuedTime)));

        Option<CommandSubmission> ICommandQueue.Enqueue(ICommandSpec command, SystemNode target, CorrelationToken? ct)
            => Enqueue((S)command, target, ct);

        public Option<CommandSubmission<S>[]> Enqueue(IEnumerable<S> commands, SystemNode target, CorrelationToken? ct)
            => ExecStore.Submit(commands, target, ct);

        public Option<CommandSubmission> Enqueue(S command, SystemNode target, CorrelationToken? ct)
            => from result in ExecStore.Submit(array(command), target, ct)
            from item in result.TryGetFirst()
            select new CommandSubmission(command, item.SubmissionId, item.CommandJson, ct, item.EnqueuedTime);

        Option<CommandDispatch> ICommandQueue.Dispatch()
            => from d  in Dispatch()
            select new CommandDispatch(
                new CommandSubmission(d.Spec, d.SubmissionId, d.CommandJson, d.CorrelationToken, d.EnqueuedTime));

        CommandDispatch[] ICommandQueue.Dispatch(int count)
            => Dispatch(count).Map(d => 
                new CommandDispatch(
                    new CommandSubmission(d.Spec, d.SubmissionId, d.CommandJson, d.CorrelationToken, d.EnqueuedTime)));

        public void Empty() 
            => ExecStore.PurgeSubmissions(none<CommandName>());

        public Type SpecType
            => typeof(S);

        public CommandName CommandName
            => CommandSpec<S>.Descriptor.CommandName;

        public bool IsEmpty()
            => ExecStore.GetCurrentSubmissionCount() == 0;

        void OnDispatch(CommandDispatch<S> dispatch)
        {

        }
        
        public CommandDispatch<S>[] Dispatch(int count)
        {              
            var dispatched = ExecStore.Dispatch<S>(count).Value;
            z.iter(dispatched, OnDispatch);            
            return dispatched;
        }

        public Option<CommandDispatch<S>> Dispatch()
            => ExecStore.Dispatch<S>();
    
        Option<CommandSubmission<S>[]> ICommandQueue<S>.Enqueue(IEnumerable<S> commands, SystemNode target, CorrelationToken? ct)
            => Enqueue(commands, target, ct)
                    .Select(x => x.Map(y => CommandSubmission.Create(y.Spec, y.SubmissionId, y.CommandJson, y.CorrelationToken, y.EnqueuedTime)));

        Option<CommandSubmission<S>> ICommandQueue<S>.Enqueue(S command, SystemNode target, CorrelationToken? ct)
            => from submissions in ExecStore.Submit(z.stream(command), target, ct)
                select submissions.SingleOrDefault();
    }
}