//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    using static Apps;
    
    public static class AppServices
    {
        public static IAppMsgWriter OpenAppMsgLog(this IContext context, FilePath target, string devname = null, 
            FileWriteMode mode = FileWriteMode.Overwrite, bool display = false)
                => AppMsgWriter.Open(context, target, devname, mode, display);
    }

    public readonly struct AppMsgWriter : IAppMsgWriter
    {
        public static AppMsgWriter Open(IContext context, FilePath target, string name = null, 
            FileWriteMode mode = FileWriteMode.Overwrite, bool display = false, AppMsgColor? color = null)
        {
            var writer = target.CreateParentIfMissing().Writer(mode);
            var devname = name ?? ("log" + core.increment(ref devid).ToString());
            return new AppMsgWriter(context, writer, devname, display, color ?? AppMsgColor.Green);            
        }

        AppMsgWriter(IContext context, StreamWriter writer, string name, bool display, AppMsgColor color)
        {
            this.Context = context;
            this.Writer = writer;
            this.Name = name;
            this.Display = display;
            this.Color = color;
        }


        static int devid;        

        public IContext Context {get;}

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