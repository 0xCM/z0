//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XTend
    {
        public static ref readonly E Deposit<E>(this IAppMsgSink dst, in E src)      
            where E : IAppEvent
        {
            dst.NotifyConsole(src.Message);
            return ref src;
        }
    }

    /// <summary>
    /// Characterizes a correlated message, accompanied by arbitrary content, that describes something that occurred
    /// within the system
    /// </summary>
    public interface IAppEvent : ICorrelated, ITextual
    {
        /// <summary>
        /// The data associated with the event
        /// </summary>
        object Content {get;}

        string Description {get;}

        bool IsError => false;

        AppMsgColor Flair => AppMsgColor.Blue;

        string ITextual.Format()        
            => Description;

        IAppMsg Message => AppMsg.Colorize(Format(), Flair);

        Outcome Subscribe(IEventBroker broker, Action<IAppEvent> receiver)
            => AppEvents.subscribe(this, broker, receiver);
    }

    /// <summary>
    /// Characterizes an F-bound polymorphic application event reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    public interface IAppEvent<F> : IAppEvent, INullary<F>
        where F : struct, IAppEvent<F>
    {
        string IAppEvent.Description
            => typeof(F).DisplayName();

        new F Content => (F)this;

        object IAppEvent.Content
            => Content;                
    }
}