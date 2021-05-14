//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/OmniSharp/omnisharp-roslyn
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Diagnostics;
    using System.Collections.Immutable;
    using System.Collections.Generic;
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.CodeAnalysis;
    using Microsoft.Extensions.Logging;
    using Microsoft.CodeAnalysis.CSharp;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.CodeAnalysis.Text;
    using NuGet.Versioning;
    using OmniSharp.Eventing;
    using OmniSharp.Services;
    using OmniSharp.Extensions;

    partial struct ProjectRunner
    {

        internal sealed class Runner : Executor
        {
            public Runner(Project project, string workingDirectory, IDotNetCliService dotNetCli, SemanticVersion dotNetCliVersion, IEventEmitter eventEmitter, ILoggerFactory loggerFactory)
            : base(project, workingDirectory, dotNetCli, dotNetCliVersion, eventEmitter, loggerFactory.CreateLogger<Runner>())
            {

            }

            object LoadRunSettingsOrDefault(string runSettingsPath, string targetFrameworkVersion)
            {
                if (runSettingsPath != null)
                {
                    try
                    {
                        return File.ReadAllText(runSettingsPath);
                    }
                    catch (FileNotFoundException)
                    {
                        EmitTestMessage(MessageLevel.Warning, $"RunSettings file {runSettingsPath} not found. Continuing with default settings...");
                    }
                    catch (Exception e)
                    {
                        EmitTestMessage(MessageLevel.Warning, $"There was an error loading runsettings at {runSettingsPath}: {e}. Continuing with default settings...");
                    }
                }

                if (!string.IsNullOrWhiteSpace(targetFrameworkVersion))
                {
                    return $@"
    <RunSettings>
        <RunConfiguration>
            <TargetFrameworkVersion>{targetFrameworkVersion}</TargetFrameworkVersion>
        </RunConfiguration>
    </RunSettings>";
                }

                return "<RunSettings/>";
            }

            async Task<TestProcessStartInfo> GetTestRunnerProcessStartInfo(TestCase[] testCases, bool debuggingEnabled, string runSettings, string targetFrameworkVersion, CancellationToken cancellationToken)
            {
                SendMessage(MessageType.GetTestRunnerProcessStartInfoForRunSelected,
                    new
                    {
                        TestCases = testCases,
                        RunSettings = LoadRunSettingsOrDefault(runSettings, targetFrameworkVersion)
                    });

                bool done = false;
                TestProcessStartInfo startInfo = null;
                while (!done)
                {
                    var (success, message) = await TryReadMessageAsync(cancellationToken);
                    if (!success)
                    {
                        return startInfo;
                    }

                    switch (message.MessageType)
                    {
                        case MessageType.TestMessage:
                            EmitTestMessage(message.DeserializePayload<MessagePayload>());
                            break;

                        case MessageType.CustomTestHostLaunch:
                            startInfo = message.DeserializePayload<TestProcessStartInfo>();
                            done = true;
                            break;

                        case MessageType.ExecutionComplete:
                            done = true;
                            break;
                    }
                }

                return startInfo;
            }

            protected override bool PrepareToConnect(bool noBuild)
            {
                if (noBuild)
                {
                    return true;
                }

                // The project must be built before we can test.
                var arguments = "build";

                // If this is .NET CLI version 2.0.0 or greater, we also specify --no-restore to ensure that
                // implicit restore on build doesn't slow the build down.
                if (DotNetCliVersion >= new SemanticVersion(2, 0, 0))
                {
                    arguments += " --no-restore";
                }

                var process = DotNetCli.Start(arguments, WorkingDirectory);

                process.OutputDataReceived += (_, e) =>
                {
                    EmitTestMessage(MessageLevel.Informational, e.Data ?? string.Empty);
                };

                process.ErrorDataReceived += (_, e) =>
                {
                    EmitTestMessage(MessageLevel.Error, e.Data ?? string.Empty);
                };

                process.BeginOutputReadLine();
                process.BeginErrorReadLine();

                process.WaitForExit();

                return process.ExitCode == 0
                    && File.Exists(Project.OutputFilePath);
            }

            public async override Task DebugLaunchAsync(CancellationToken cancellationToken)
            {
                SendMessage(MessageType.CustomTestHostLaunchCallback,
                    new
                    {
                        HostProcessId = Process.GetCurrentProcess().Id
                    });

                var done = false;

                while (!done)
                {
                    var (success, message) = await TryReadMessageAsync(cancellationToken);
                    if (!success)
                    {
                        break;
                    }

                    switch (message.MessageType)
                    {
                        case MessageType.TestMessage:
                            EmitTestMessage(message.DeserializePayload<MessagePayload>());
                            break;

                        case MessageType.ExecutionComplete:
                            done = true;
                            break;
                    }
                }
            }

            public override async Task<(string[] MethodNames, string TestFramework)> GetContextTestMethodNames(int line, int column, Document contextDocument, CancellationToken cancellationToken)
            {
                Logger.LogDebug($"Loading info for {contextDocument.FilePath} {line}:{column}");
                var syntaxTree = await contextDocument.GetSyntaxTreeAsync(cancellationToken);
                if (syntaxTree is null)
                {
                    return default;
                }

                var semanticModel = await contextDocument.GetSemanticModelAsync(cancellationToken);
                if (semanticModel is null)
                {
                    return default;
                }

                var sourceText = await contextDocument.GetTextAsync();

                var position = sourceText.Lines.GetPosition(new LinePosition(line, column));
                var node = (await syntaxTree.GetRootAsync()).FindToken(position).Parent;

                string[]? methodNames = null;
                object testFramework = null;

                while (node is object)
                {
                    if (node is MethodDeclarationSyntax methodDeclaration)
                    {
                        // If a user invokes a test before or after a test method, it's likely that
                        // they meant the context to be the entire containing type, not the current
                        // methodsyntax to which the trivia was attached to. If we're in that scenario,
                        // just continue searching up.
                        if (position < methodDeclaration.SpanStart || position >= methodDeclaration.Span.End)
                        {
                            node = node.Parent;
                            continue;
                        }

                        var methodSymbol = semanticModel.GetDeclaredSymbol(methodDeclaration, cancellationToken);
                        if (methodSymbol is null)
                        {
                            Logger.LogWarning($"Could not find method symbol for method syntax {node} {contextDocument.FilePath} {node.SpanStart}:{node.Span.End}. This should not be possible.");
                            Debug.Fail($"Did not find method symbol");
                            continue;
                        }


                        Logger.LogDebug($"Method {methodSymbol.Name} is not a test method, searching containing type");
                    }
                    else if (node is ClassDeclarationSyntax classDeclaration)
                    {
                        var typeSymbol = semanticModel.GetDeclaredSymbol(classDeclaration);
                        if (typeSymbol is null)
                        {
                            Logger.LogWarning($"Could not find type symbol for class declaration syntax {node} {contextDocument.FilePath} {node.SpanStart}:{node.Span.End}. This should not be possible.");
                            Debug.Fail($"Did not find class symbol symbol");
                            continue;
                        }

                        var members = typeSymbol.GetMembers();
                        ImmutableArray<string>.Builder? nameBuilder = null;

                        foreach (var member in members)
                        {
                            // This might be longer than the members we end up needing, but at least we won't do expensive
                            // array reallocation during search.
                            nameBuilder ??= ImmutableArray.CreateBuilder<string>(members.Length);
                            nameBuilder.Add(member.GetMetadataName());
                        }

                        if (nameBuilder is object)
                        {
                            methodNames = nameBuilder.ToArray();
                            Logger.LogDebug($"Found test methods {string.Join(", ", methodNames)}");
                            break;
                        }

                        Logger.LogDebug($"Class {typeSymbol.Name} does not contain test methods, searching containing type (if applicable)");
                    }

                    node = node.Parent;
                }

                return (methodNames, "");
            }

            protected override string GetCliTestArguments(int port, int parentProcessId)
            {
                return $"ztest --Port:{port} --ParentProcessId:{parentProcessId}";
            }


            protected override void VersionCheck()
            {

            }
        }
    }
}