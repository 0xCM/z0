//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAppMsg : ICustomFormattable
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
    }
}