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

    using static Root;

    /// <summary>
    /// Implments a thread-safe/thread-aware terminal absraction
    /// </summary>
    public class Terminal
    {
        [MethodImpl(Inline)]
        public static Terminal Get() => TheOnly;
        
        static readonly Terminal TheOnly = new Terminal();
        
        readonly object locker;
     
        Option<Action> TerminationHandler;

        Terminal()
        {
             locker = new object();
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

        void WriteLine(object src)
        {
            lock(locker)
                Console.WriteLine(src);
        }             

        public void WriteLine()
        {
            lock(locker)
                Console.WriteLine();
        }
                
        void Write(object src)
        {
            lock(locker)
                Console.Write(src);
        }
        
        void WriteLine<T>(IEnumerable<T> items, string sep)
        {
            lock(locker)
            {
                var written = false;
                foreach(var item in items)
                {
                    if(!written)
                        written = true;
                    else
                        Console.Write(sep);

                    Console.Write($"{item}");
                }
                if(!written)
                    Console.Write("∅");            
                Console.WriteLine();
            }
        }
            
        void WriteLine(object src, AppMsgColor color)
        {
            lock(locker)
            {
                var current = Console.ForegroundColor;
                Console.ForegroundColor = (ConsoleColor)color;                
                Console.WriteLine(src);
                Console.ForegroundColor = current;
            }
        }

        void WriteError(object src, AppMsgColor color)
        {
            lock(locker)
            {
                var current = Console.ForegroundColor;
                Console.ForegroundColor = (ConsoleColor)color;                
                Console.Error.Write(src);
                Console.Error.Write(AsciEscape.Eol);
                Console.ForegroundColor = current;
            }
        }

        public void WriteLine(object src, AppMsgKind kind)
        {
            if(kind == AppMsgKind.Error) 
                WriteError(src,(AppMsgColor)kind);
            else
                WriteLine(src, (AppMsgColor)kind);
        }

        void Write(object src, ConsoleColor color)
        {
            lock(locker)
            {
                var current = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.Write(src);
                Console.ForegroundColor = current;
            }
        }

        /// <summary>
        /// Writes a single character to the console
        /// </summary>
        /// <param name="c">The char to emit</param>
        /// <param name="severity">The severity</param>
        public void WriteChar(char c, AppMsgKind? severity = null)
            => Write(c, ForeColor(severity ?? AppMsgKind.Info));

        public void WriteMessage(AppMsg msg)
        {   
            if(msg.Kind == AppMsgKind.Error)
                WriteError(msg, msg.Color);
            else
                WriteLine(msg, msg.Color); 
        }

        public void WriteLines<F>(params F[] formattables)
            where F : ICustomFormattable
        {
            lock(locker)            
            {
                foreach(var msg in formattables)
                    Console.WriteLine(msg);
            }            
        }

        public void WriteLines<F>(AppMsgColor color, params F[] formattables)
            where F : ICustomFormattable
        {
            lock(locker)            
            {
                var current = Console.ForegroundColor;
                Console.ForegroundColor = (ConsoleColor)color;
                foreach(var msg in formattables)
                    Console.WriteLine(msg);
                Console.ForegroundColor = current;
            }            
        }

        public void WriteMessages(IEnumerable<AppMsg> messages)
        {
            lock(locker)            
            {
                var current = Console.ForegroundColor;
                foreach(var msg in messages)
                {
                    Console.ForegroundColor = (ConsoleColor)msg.Color;
                    Console.WriteLine(msg);
                    Console.ForegroundColor = current;
                }                
                Console.ForegroundColor = current;
            }            
        }

        public string ReadLine(AppMsg msg = null)
        {
             if(msg != null)
                WriteMessage(msg);
             return Console.ReadLine();
        }

        public char ReadKey(AppMsg msg = null)
        {
             if(msg != null)
                WriteMessage(msg);
              
            return Console.ReadKey().KeyChar;
        }

        static ConsoleColor ForeColor(AppMsgKind level)
            => (ConsoleColor)level;
    }
}
