//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    
    using static Seed;
    using static Memories;

    public class AsmContext : IAsmContext 
    {            
        /// <summary>
        /// Creates a base context with a specified composition
        /// </summary>
        /// <param name="assemblies">A composition of assemblies to share with the context</param>
        public static IAsmContext Create(
            IApiComposition assemblies, 
            IAppSettings settings, 
            IAppMsgExchange exchange, 
            IPolyrand random, 
            AsmFormatConfig format,
            IAsmFormatter formatter,
            IAsmFunctionDecoder decoder,
            AsmWriterFactory writerFactory)
                => new AsmContext(assemblies, settings, exchange, random, format, formatter, decoder, writerFactory);

        AsmContext(
            IApiComposition composition, 
            IAppSettings settings, 
            IAppMsgExchange exchange, 
            IPolyrand random, 
            AsmFormatConfig format,
            IAsmFormatter formatter,
            IAsmFunctionDecoder decoder,
            AsmWriterFactory writerFactory)
        {
            Next += BlackHole;
            Messaging = exchange;
            Settings = settings;
            Messaging.Next += Relay;            
            Random = random;
            AsmFormat = format;
            Settings = settings;
            Paths = AppPathProvider.Create(Assembly.GetEntryAssembly().Id(), Env.Current.LogDir);  
            ApiSet = Z0.ApiSet.Create(composition);
            AsmFormatter = formatter;
            AsmDecoder = decoder;
            WriterFactory = writerFactory;            
        }

        public event Action<AppMsg> Next;

        public IPolyrand Random {get;}

        IAppMsgExchange Messaging {get;}
        
        public IAppSettings Settings {get;}

        public AsmFormatConfig AsmFormat {get;}

        public IApiSet ApiSet {get;}

        public IAppPaths Paths {get;}

        public IAsmFormatter AsmFormatter {get;}
        
        public IAsmFunctionDecoder AsmDecoder {get;}
        
        AsmWriterFactory WriterFactory {get;}

        public IAsmStreamWriter AsmWriter(FilePath dst)
            => WriterFactory(dst, AsmFormatter);

        void BlackHole(AppMsg msg) {}

        void Relay(AppMsg msg)
            => Next(msg);
              
        public void Notify(AppMsg msg)
            => Messaging.Notify(msg);

        public void Notify(string msg, AppMsgKind? severity = null)
            => Messaging.Notify(msg, severity);

        public IReadOnlyList<AppMsg> Dequeue()
            => Messaging.Dequeue();

        public IReadOnlyList<AppMsg> Flush(Exception e)
            => Messaging.Flush(e);

        public void Emit(FilePath dst) 
            => Messaging.Emit(dst);
    }   
}