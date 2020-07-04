//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    using static Konst;

    public interface ITerminal
    {
        void SetTerminationHandler(Action handler);        
         
        void WriteLine();

        void WriteLine(object src, AppMsgKind kind);        

        void WriteLine(string src, AppMsgColor kind);        

        void WriteChar(char c, AppMsgColor? color = null);

        void WriteMessage(IAppMsg msg, AppMsgColor? color = null);

        void WriteMessages(IEnumerable<IAppMsg> messages);

        void WriteLines<F>(params F[] src)
            where F : ITextual;        

        void WriteLine<F>(F src, AppMsgColor color)
            where F : ITextual;

        void WriteLines<F>(AppMsgColor color, params F[] src)
            where F : ITextual;

        string ReadLine(IAppMsg msg = null);

        char ReadKey(IAppMsg msg = null);
    }
}