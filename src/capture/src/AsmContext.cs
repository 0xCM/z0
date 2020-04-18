//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    
    using static Seed;
    using static Memories;

    public class AsmContext : IAsmContext 
    {            
        public event Action<IAppMsg> Next;

        public IPolyrand Random {get;}

        public IAppMsgExchange Messaging {get;}
        
        public IAppSettings Settings {get;}

        public AsmFormatConfig AsmFormat {get;}

        public FolderPath RootCapturePath {get;}

        public IApiSet ApiSet {get;}

        public IAppPaths AppPaths {get;}

        public IAsmFormatter Formatter {get;}
        
        public IAsmFunctionDecoder Decoder {get;}

        public static IAsmContext Create(IAppSettings settings, IAppMsgExchange exchange, IApiComposition api, FolderPath root)
        {
            var context = IContext.Default;
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var format = AsmFormatConfig.New;            
            var decoder = AsmDecoder.function(context, format);
            var formatter = AsmDecoder.formatter(context, format);
            var factory = AsmDecoder.writerFactory(context);
            return AsmContext.Create(settings, exchange, api, root, random, format, formatter, decoder, factory);
        }

        /// <summary>
        /// Creates a base context with a specified composition
        /// </summary>
        /// <param name="assemblies">A composition of assemblies to share with the context</param>
        public static IAsmContext Create(
            IAppSettings settings, 
            IAppMsgExchange exchange, 
            IApiComposition assemblies, 
            FolderPath root,            
            IPolyrand random, 
            AsmFormatConfig format,
            IAsmFormatter formatter,
            IAsmFunctionDecoder decoder,
            AsmWriterFactory writerFactory)
                => new AsmContext(assemblies, settings, exchange, root, random, format, formatter, decoder, writerFactory);

        AsmContext(
            IApiComposition composition, 
            IAppSettings settings, 
            IAppMsgExchange exchange, 
            FolderPath root,            
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
            RootCapturePath = root;      
            Random = random;
            AsmFormat = format;
            Settings = settings;
            AppPaths = IAppPaths.Default;
            ApiSet = composition.ApiSet();
            Formatter = formatter;
            Decoder = decoder;
            WriterFactory = writerFactory;            
        }
        
        AsmWriterFactory WriterFactory {get;}

        public IAsmFunctionWriter Writer(FilePath dst)
            => WriterFactory(dst, Formatter);

        public void Deposit(IAppMsg msg)
            => Messaging.Deposit(msg);

        public void Notify(string msg, AppMsgKind? severity = null)
            => Messaging.Notify(msg, severity);

        public IReadOnlyList<IAppMsg> Dequeue()
            => Messaging.Dequeue();

        public IReadOnlyList<IAppMsg> Flush(Exception e)
            => Messaging.Flush(e);

        public void Emit(FilePath dst) 
            => Messaging.Emit(dst);

        void BlackHole(IAppMsg msg) {}

        void Relay(IAppMsg msg)
            => Next(msg);
    }   
}