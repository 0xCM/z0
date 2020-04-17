//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices; 
    using System.Text;

    using static Seed;

    public interface ITerminal : IService
    {
        void SetTerminationHandler(Action handler);        

        void WriteLine();

        void WriteLine(object src, AppMsgKind kind);        

        void WriteChar(char c, AppMsgColor? color = null);

        void WriteMessage(IAppMsg msg, AppMsgColor? color = null);

        void WriteMessages(IEnumerable<IAppMsg> messages);

        void WriteLines<F>(params F[] src)
            where F : ICustomFormattable;        

        void WriteLine<F>(F src, AppMsgColor color)
            where F : ICustomFormattable;

        void WriteLines<F>(AppMsgColor color, params F[] src)
            where F : ICustomFormattable;

        string ReadLine(IAppMsg msg = null);

        char ReadKey(IAppMsg msg = null);
    }
}