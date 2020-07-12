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

    using static Konst;

    /// <summary>
    /// Implments a thread-safe/thread-aware terminal absraction
    /// </summary>
    public class Terminal : ITerminal
    {
        [MethodImpl(Inline)]
        public static Terminal Get() => TheOnly;
        
        static readonly Terminal TheOnly = new Terminal();
        
        readonly object TermLock;

        readonly object ErrLock;

        readonly object StdLock;
     
        Option<Action> TerminationHandler;

        Terminal()
        {
             TermLock = new object();
             ErrLock = new object();             
             StdLock = new object();
             Console.OutputEncoding = new UnicodeEncoding();      
             Console.CancelKeyPress += OnCancelKeyPressed;        
        }

        /// <summary>
        /// Specfifies the handler to invoke when the user enters a cancellation
        /// command, such as Ctrl+C
        /// </summary>
        /// <param name="handler">The handler to invoke when a termination command is received</param>
        public void SetTerminationHandler(Action handler)
            => TerminationHandler = handler;

        void OnCancelKeyPressed(object sender, ConsoleCancelEventArgs args)
            => TerminationHandler.OnSome(h => h());

        public void WriteLine()
        {
            lock(TermLock)
                Console.WriteLine();
        }
                                    
        /// <summary>
        /// Writes a single character to the console
        /// </summary>
        /// <param name="c">The char to emit</param>
        /// <param name="severity">The severity</param>
        public void WriteChar(char c, AppMsgColor? color = null)
            => Write(c, (ConsoleColor)(color ?? AppMsgColor.Yellow));

        public void WriteMessage(IAppMsg msg, AppMsgColor? color = null)
        {   
            if(msg.Kind == AppMsgKind.Error)
                WriteError(msg);
            else
                WriteLine(msg, color ?? msg.Color); 
        }

        public void WriteLines<F>(params F[] src)
            where F : ITextual
        {
            lock(TermLock)            
            {
                foreach(var item in src)
                    Console.WriteLine(item.Format());
            }            
        }

        public void WriteLine<F>(F src, AppMsgColor color)
            where F : ITextual
        {
            lock(TermLock)            
            {
                var current = Console.ForegroundColor;
                Console.ForegroundColor = (ConsoleColor)color;
                Console.WriteLine(src.Format());
                Console.ForegroundColor = current;
            }
        }

        public void WriteLines<F>(AppMsgColor color, params F[] src)
            where F : ITextual
        {
            lock(TermLock)            
            {
                var current = Console.ForegroundColor;
                Console.ForegroundColor = (ConsoleColor)color;
                foreach(var msg in src)
                    Console.WriteLine(msg);
                Console.ForegroundColor = current;
            }            
        }

        public void WriteMessages(IEnumerable<IAppMsg> messages)
        {
            lock(TermLock)            
            {
                var current = Console.ForegroundColor;
                foreach(var msg in messages)
                {
                    Console.ForegroundColor = (ConsoleColor)msg.Color;
                    if(msg.IsError)
                        Console.Error.WriteLine(msg);
                    else
                        Console.WriteLine(msg);
                    Console.ForegroundColor = current;
                }                
                Console.ForegroundColor = current;
            }            
        }

        public string ReadLine(IAppMsg msg = null)
        {
             if(msg != null)
                WriteMessage(msg);
             return Console.ReadLine();
        }

        public char ReadKey(IAppMsg msg = null)
        {
             if(msg != null)
                WriteMessage(msg);
              
            return Console.ReadKey().KeyChar;
        }

        void WriteLine(object src, AppMsgColor color)
        {
            lock(TermLock)
            {
                var current = Console.ForegroundColor;
                Console.ForegroundColor = (ConsoleColor)color;                
                Console.WriteLine(src);
                Console.ForegroundColor = current;
            }
        }


        void WriteWarning(object src)
        {
            lock(TermLock)
            {
                var current = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(src);
                Console.ForegroundColor = current;
            }
        }

        void Write(object src, ConsoleColor color)
        {
            lock(TermLock)
            {
                var current = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.Write(src);
                Console.ForegroundColor = current;
            }
        }

        void Log(IAppMsg msg)
        {
            var dst = AppEnv.Default.AppPaths.AppErrorOutPath;
            var rendered = msg.Format();
            lock(ErrLock)
            {
                dst.AppendLine(rendered);
            }
        }
        
        public void WriteError(IAppMsg src)
        {
            lock(TermLock)
            {                
                var current = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.Write(src);
                Console.Error.Write(Chars.Eol);
                Console.ForegroundColor = current;    
            }  

            Log(src);          
        }

        // void WriteError(Exception src)
        // {
        //     lock(TermLock)
        //     {                
        //         var current = Console.ForegroundColor;
        //         Console.ForegroundColor = ConsoleColor.Red;
        //         Console.Error.Write(src);
        //         Console.Error.Write(Chars.Eol);
        //         Console.ForegroundColor = current;    
        //     }            
        // }

        public void WriteLine(object sr)
            => WriteLine(sr, AppMsgColor.Green);


        // public void Error(Exception e)
        //     => WriteError(e);

        public void Warn(string description)
            => WriteWarning((object)description);
        
        public void Info(string message)
            => WriteLine((object)message, AppMsgColor.Green);

        public void WriteLine(string message, AppMsgColor color)
            => WriteLine((object)message, color);
    }
}