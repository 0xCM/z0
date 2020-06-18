//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

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

        AppMsgColor Flair 
            => AppMsgColor.Blue;

        string ITextual.Format()        
            => Description;

        IAppMsg Message 
            => AppMsg.Colorize(Format(), Flair);
    }
}