//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAppMsg : ITextual
    {
        /// <summary>
        /// The message body
        /// </summary>
        object Content {get;}

        /// <summary>
        /// The message classification
        /// </summary>
        AppMsgKind Kind {get;}

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        AppMsgColor Color {get;}        

        /// <summary>
        /// Specifies whether the message has been displayed to an end-user
        /// </summary>
        bool Displayed {get;}        

        /// <summary>
        /// Transitions a message to the displayed state
        /// </summary>
        IAppMsg AsDisplayed();      

        /// <summary>
        /// Specifies whether the message is vaccuous
        /// </summary>
        bool IsEmpty
            => Content == null || (Content is string s && string.IsNullOrWhiteSpace(s));

        /// <summary>
        /// Specifies whether the message describes an error
        /// </summary>
        bool IsError 
            => Kind == AppMsgKind.Error;
    }
}