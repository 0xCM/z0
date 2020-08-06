//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static Flow;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    /// <summary>
    /// Characterizes a worklow context
    /// </summary>
    public interface IWfContext : IDisposable
    {
        IAppContext ContextRoot {get;}

        WfEventId Raise<E>(in E e)
            where E : IWfEvent;        

        void Error(Exception e, CorrelationToken ct, [Caller] string caller  = null, [File] string file = null, [Line] int? line = null)
            => Flow.error(this, e, ct, caller, file, line);

        void Error<T>(string worker, T body, CorrelationToken ct)
            => Flow.error(worker, body, ct);
    }

    /// <summary>
    /// Characterizes a workflow context that carries parametric cata
    /// </summary>
    /// <typeparam name="T">The data type</typeparam>
    public interface IWfContext<T> : IWfContext
    {
        T State {get;}
    }    
}