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

        void WriteLine(object src);        

        void WriteLine(string src, MessageFlair kind);        

        void WriteChar(char c, MessageFlair? color = null);

        void WriteMessage(IAppMsg msg, MessageFlair? color = null);

        void WriteMessages(IEnumerable<IAppMsg> messages);

        void WriteLines<F>(params F[] src)
            where F : ITextual;        

        void WriteLine<F>(F src, MessageFlair color)
            where F : ITextual;

        void WriteLines<F>(MessageFlair color, params F[] src)
            where F : ITextual;

        string ReadLine(IAppMsg msg = null);

        char ReadKey(IAppMsg msg = null);
    }
}