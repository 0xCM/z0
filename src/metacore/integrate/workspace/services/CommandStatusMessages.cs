//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.MetaCore
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics.Tracing;
    using System.Text;
    using System.Linq;

    public static class CommandStatusMessages
    {    
        static CommandStatusMessage CommandStatus(ICommandSpec spec, string template, CorrelationToken? ct = null,
            [CallerMemberName] string messageType = null)
            => new CommandStatusMessage(spec, null, AppMsgKind.Info, template, ct, messageType);

        public static IAppMsg Completed(ICommandSpec spec, string Template = null)
            => CommandStatus(spec, Template ?? "The @CommandName command completed");

        public static IAppMsg SpecNotFound(string SpecName)
            => AppMsg.Parametric("The specification @SpecName could not be found", 
                new
                {
                    SpecName
                });

        public static IAppMsg CommandResultComputed(ICommandResult result)
        => result.Succeeded
            ? AppMsg.Parametric("Successfully completed execution of the @CommandName with submission id @SubmissionId", new
            {
                result.Spec.CommandName,
                result.SubmissionId
            })
            : result.Message;

        public static IAppMsg CompletedCommand(ICommandCompletion completion)
        => completion.Succeeded ?
            AppMsg.Parametric(
                $"Finished executing {completion.CommandName} command: {completion.CompleteMessage}",
                completion)
            : AppMsg.Parametric(
                $"Finished executing {completion.CommandName} command: {completion.CompleteMessage}", 
                completion);

        public static IAppMsg Error(this ICommandSpec spec, Exception e)
            => AppMsg.Parametric("An occurred during execution of the @CommandName - @ErrorDescription: @ErrorDetail", 
                new
                {
                    spec.CommandName,
                    ErrorDescription = e.Message,
                    ErrorDetail = e.ToString()
                }, AppMsgKind.Error);

        public static IAppMsg ExecutingCommand(ICommandSpec spec)
            => AppMsg.Parametric("Executing the @SpecName specification of the @CommandName command", new
            {
                spec.CommandName,
                spec.SpecName
            });

        public static IAppMsg CompletedCommandExecution(ICommandSpec spec, object payload = null)
            => AppMsg.Parametric($"Executed @SpecName", new
            {
                spec.CommandName,
                spec.SpecName,
                Description =  spec.ToString()
            });

        public static IAppMsg ExecutorNotFound(CommandName CommandName)
            => AppMsg.Parametric(
                    "No executor for @CommandName was found",
                    new
                    {
                        CommandName
                    }, 
                    AppMsgKind.Error
                );

        public static IAppMsg UnhandledExecutionError(ICommandSpec spec, Exception e)
            => AppMsg.Parametric(
                "Error executing command @CommandName: @ErrorDetail",
                new
                {
                    CommandName = spec.CommandName,
                    ErrorDetail = e.ToString()
                },
                AppMsgKind.Error
                );

        public static IAppMsg EmptyCommandResult(ICommandSpec command)
            => AppMsg.Parametric($"No result available for the @CommandName command", new
            {
                CommandName = command.CommandName,
                Detail = command.ToString()
            });

        public static IAppMsg OrchestrationStartError(string CommandName, Exception e)
            => AppMsg.Parametric(
                "Could not start @CommandName orchestration, @Message - @ErrorDetails", new
            {
                CommandName,
                e.Message,
                ErrorDetails = e.ToString()
            },
            AppMsgKind.Error
            );

        public static IAppMsg CancelingOrchestration(CommandSpecDescriptor d)
            => AppMsg.Parametric("Command orchestration for @CommandName was cancelled", new
            {
                d.CommandName
            });

        public static IAppMsg CancelledOrchestration(CommandSpecDescriptor d)
            => AppMsg.Parametric("Command orchestration for @CommandName was cancelled", new
            {
                d.CommandName
            });

        public static IAppMsg OrchestratedTasksStillExecuting(CommandSpecDescriptor d)
            => AppMsg.Parametric("@CommandName commands are still executing", new
            {
                d.CommandName
            },
            AppMsgKind.Warning
            );

        public static IAppMsg EnqueuedNewCommands(CommandSpecDescriptor d, int Count)
            => AppMsg.Parametric("Enqueued @Count new @CommandName commands", new
            {           
                d.CommandName,
                Count
            },
            AppMsgKind.Warning
            );

        public static IAppMsg NoCommandsAvailable(string CommandName)
            => AppMsg.Parametric("No @CommandName commands are available for scheduling", new
            {
                CommandName
            });

        public static IAppMsg CommandQueueIsEmpty(string CommandName)
            => AppMsg.Parametric(
                "The @CommandName queue is empty", new
            {
                CommandName
            },
            AppMsgKind.Babble
            );

        public static IAppMsg DispatchedCommands(string CommandName, int Count)
            => AppMsg.Parametric(
                "Dispatched @Count @CommandName commands", new
            {
                CommandName,
                Count
            });

        public static IAppMsg OrchestrationDisabled(string CommandName)
            => AppMsg.Parametric(
                "Orchestration for @CommandName commands is disabled", new
            {
                CommandName
            });

        public static IAppMsg CalculatingNewCommands(string CommandName)
            => AppMsg.Parametric(
                "Calculating new @CommandName commands", new
            {
                CommandName
            });

        public static IAppMsg OrchestrationStarted(string CommandName)
            => AppMsg.Parametric(
                "Orchestration started for @CommandName commands", new
            {
                CommandName
            });

        public static IAppMsg OrchestratorAlreadyRunning(CommandName CommandName)
            => AppMsg.Parametric("Orchestration for the @CommandName command is already underway",
                new
                {
                    CommandName
                });

        public static IAppMsg StartingOrchestration(CommandName CommandName)
            => AppMsg.Parametric(
                "Starting @CommandName command orchestration",
                new
                {
                    CommandName
                });

        public static IAppMsg OrchestrationCompleted(string CommandName)
            => AppMsg.Parametric(
                "Orchestration completed for @CommandName commands", new
            {
                CommandName
            });

        public static IAppMsg OrchestrationPausing(string CommandName, int Duration)
            => AppMsg.Parametric(
                "Orchestration for @CommandName commands pausing for @Duration ms", new
            {
                CommandName,
                Duration
            },
            AppMsgKind.Babble
            );

        public static IAppMsg OrchestrationCancellationRequestReceived(string CommandName)
            => AppMsg.Parametric(
                "Orchestration cancellation request received for @CommandName", new
            {
                CommandName,
            });

        public static IAppMsg OrchestrationManagerCreated(string CommandName)
            => AppMsg.Parametric(
                "Orchestration manager for @CommandName commands created", new
            {
                CommandName
            });

        public static IAppMsg CommandSucceeded(ICommandResult result)
            => AppMsg.Parametric(
                "Executing the @SpecName specification of the @CommandName command succeeded", new
            {
                result.Spec.CommandName,
                result.Spec.SpecName
            });

        public static IAppMsg CommandFailed(ICommandResult result)
            => AppMsg.Parametric(
                "Executing the @SpecName specification of the @CommandName command failed", new
                {
                    result.Spec.CommandName,
                    result.Spec.SpecName
                },
                AppMsgKind.Error
                );
    
        public static IAppMsg CommandCompletionError(ICommandResult result, IAppMsg CompletionMessage)
            => AppMsg.Parametric(
                "Successfully executed the @CommandName command but was unable to complete it: @CompletionError",
                    new
                    {
                        result.Spec.CommandName,
                        CompletionError = CompletionMessage.Format()
                    },
                    
                    AppMsgKind.Error);

        public static IAppMsg CommandExecutionAndCompletionError(ICommandResult result, IAppMsg CompletionMessage)
            => AppMsg.Parametric(
                "An error occurred while executing the @CommandName command and also unabled to complete it: Execution Error - @ExecutionError; Completion Error = @CompletionError",
                new
                {
                    result.Spec.CommandName,
                    ExecutionError = result.Message.Format(),
                    CompletionError = CompletionMessage.Format()
                },            
                AppMsgKind.Error
                );

        public static IAppMsg PatternNotFound(ICommandSpec spec)
            => AppMsg.Parametric("The pattern for the @CommandName as specified by the @SpecName spec could not be found", new
            {
                spec.CommandName,
                spec.SpecName
            },
            AppMsgKind.Error
            );

        public static IAppMsg PatternNotFound(Type specType)
            => AppMsg.Parametric("The pattern for the the specification type @SpecTypeName could not be found", new
            {
                SpecTypeName = specType
            },
            AppMsgKind.Error
            );

        public static IAppMsg PatternNotFound(CommandName name)
            => AppMsg.Parametric("The pattern for the the @CommandName command could not be found", new
            {
                CommandName = name
            },
            AppMsgKind.Error
            );

        public static IAppMsg HandlerNotFound(string CommandName)
            => AppMsg.Parametric(
                "No handler could be found for the @CommandName command",
                new
                {
                    CommandName
            },
            AppMsgKind.Error
            );


        public static IAppMsg CapabilityNotImplemented(string CapabilityDescription)
            => AppMsg.Parametric(
                "Capability not implemented: @CapabilityDescription", new
            {
                CapabilityDescription
            },
            AppMsgKind.Error
            );
    }
}