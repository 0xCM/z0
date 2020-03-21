//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using static Root;
    
    public readonly struct LogDevice : ILogDevice
    {
        public static LogDevice Open(IAppContext context, FilePath target, string name = null, 
            FileWriteMode mode = FileWriteMode.Overwrite, bool display = false, AppMsgColor? color = null)
        {
            var writer = target.CreateParentIfMissing().Writer(mode);
            var devname = name ?? ("log" + increment(ref devid).ToString());
            return new LogDevice(context, writer, devname, display, color ?? AppMsgColor.Green);            
        }

        LogDevice(IAppContext context, StreamWriter writer, string name, bool display, AppMsgColor color)
        {
            this.Context = context;
            this.Writer = writer;
            this.Name = name;
            this.Display = display;
            this.Color = color;
        }


        static int devid;        

        public IAppContext Context {get;}

        readonly AppMsgColor Color;    
        
        readonly StreamWriter Writer;                

        public string Name {get;}

        public bool Display {get;}

        public void Write<F>(F msg)
            where F : ICustomFormattable
        {
            if(Display)
                term.print(Color, msg);
            
            Writer.WriteLine(msg.Format());            
        }

        public void Write<F>(F[] messages)        
            where F : ICustomFormattable
        {
            if(Display)
                term.print(Color, messages);

            foreach(var m in messages)
                Writer.WriteLine(m.Format());
        }
        
        public void Dispose()
        {
            Writer?.Flush();
            Writer?.Dispose();
        }
    }
}