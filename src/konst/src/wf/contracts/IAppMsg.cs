//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IAppMsg : ITextual
    {

        /// <summary>
        /// The message classification
        /// </summary>
        MessageKind Kind {get;}

        /// <summary>
        /// The message foreground color when rendered for display
        /// </summary>
        MessageFlair Flair {get;}

        /// <summary>
        /// Specifies whether the message describes an error
        /// </summary>
        bool IsError
            => Kind == MessageKind.Error;
    }

    public interface IAppMsg<T> : IAppMsg
    {
        T Content {get;}
    }
}