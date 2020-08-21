//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes console-controlled, perhaps user-initiated, thread of execution
    /// </summary>
    public interface IShell : IExecutable, IDisposable, ITextual
    {
        PartId AppId {get;}

        void OnFatalError(Exception e);

        void RunShell(params string[] args);

        /// <summary>
        /// The path to the application status log
        /// </summary>
        FilePath StatusLogPath
            => EnvVars.Common.LogRoot + FolderName.Define("apps") + FileName.Define(AppId.Format(), FileExtensions.StatusLog);

        /// <summary>
        /// The path to the application status log
        /// </summary>
        FilePath ErrorLogPath
            => EnvVars.Common.LogRoot + FolderName.Define("apps") + FileName.Define(AppId.Format(), FileExtensions.ErrorLog);

        string ITextual.Format()
            => AppId.Format();

        void Print(object content, MessageFlair? color = null)
        {
            var term = Terminal.Get();
            term.WriteLine($"{content}", color ?? MessageFlair.Green);
        }

        void IExeModule<string>.Execute(params string[] args)
        {
            try
            {
               RunShell(args);
            }
            catch (Exception e)
            {
                OnFatalError(e);
            }
        }
    }

    /// <summary>
    /// Characterizes a reified shell
    /// </summary>
    public interface IShell<S> : IShell
        where S : IShell<S>, new()
    {
        PartId IShell.AppId
            => typeof(S).Assembly.Id();

    }

    /// <summary>
    /// Characterizes a reified shell with parametric context
    /// </summary>
    public interface IShell<S,C> : IShell<S>
        where S : IShell<S,C>, new()
        where C : IContext
    {

    }
}