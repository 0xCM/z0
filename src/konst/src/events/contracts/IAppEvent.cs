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
    public interface IAppEvent : ICorrelated, ITextual, IChronic
    {
        AppMsgColor Flair 
            => AppMsgColor.Blue;

        bool IsError 
            => Flair == AppMsgColor.Red;
    }
}