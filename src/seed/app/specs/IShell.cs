//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Characterizes console-controlled, perhaps user-initiated, thread of execution
    /// </summary>
    public interface IShell : IExecutable, IServiceAllocation, ITextual
    {        
        void OnFatalError(Exception e);

        FolderPath AppLogDir => Env.Current.LogDir + FolderName.Define("apps");

        FilePath AppLogPath {get;}

        PartId AppId {get;}

        void RunShell(params string[] args);

        string ITextual.Format() => AppId.Format();

        void Print(object content, AppMsgColor? color = null)
        {
            var term = Terminal.Get();
            term.WriteLine($"{content}", color ?? AppMsgColor.Green);
        }
        
        void IExecutable<string>.Execute(params string[] args)
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
        PartId IShell.AppId => typeof(S).Assembly.Id();

        FilePath IShell.AppLogPath => AppLogDir + FileName.Define(AppId.Format(), FileExtensions.Log);
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