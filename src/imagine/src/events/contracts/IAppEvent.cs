//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    /// <summary>
    /// Characterizes a correlated message, accompanied by arbitrary content, 
    /// that describes an occurrence of something interesting
    /// </summary>
    public interface IAppEvent : ICorrelated, ITextual
    {
        /// <summary>
        /// The data associated with the event
        /// </summary>
        object Content {get;}

        string Description {get;}

        bool IsError 
            => false;

        AppMsgColor Flair 
            => AppMsgColor.Blue;

        string ITextual.Format()        
            => Description;

        IAppMsg Message 
            => AppMsg.Colorize(Format(), Flair);
    }
}