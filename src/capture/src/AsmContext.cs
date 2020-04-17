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
        public static IAsmContext Create(IAppSettings settings, params IPart[] parts)
        {
            var context = IContext.Default;
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var resolved = ApiComposition.Assemble(parts.Where(r => r.Id != 0));
            var format = AsmFormatConfig.New;            
            var decoder = AsmDecoder.function(context, format);
            var formatter = AsmDecoder.formatter(context, format);
            var factory = AsmDecoder.writerFactory(context);
            return AsmContext.Create(resolved, settings, AppMessages.exchange(), random, format, formatter, decoder, factory);
        }

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
            AppPaths = AppPathProvider.Create(Assembly.GetEntryAssembly().Id(), Env.Current.LogDir);  
            ApiSet = Z0.ApiSet.Create(composition);
            Formatter = formatter;
            Decoder = decoder;
            WriterFactory = writerFactory;            
        }

        public event Action<IAppMsg> Next;

        public IPolyrand Random {get;}

        public IAppMsgExchange Messaging {get;}
        
        public IAppSettings Settings {get;}

        public AsmFormatConfig AsmFormat {get;}

        public IApiSet ApiSet {get;}

        public IAppPaths AppPaths {get;}

        public IAsmFormatter Formatter {get;}
        
        public IAsmFunctionDecoder Decoder {get;}
        
        AsmWriterFactory WriterFactory {get;}

        public IFunctionStreamWriter Writer(FilePath dst)
            => WriterFactory(dst, Formatter);

        void BlackHole(IAppMsg msg) {}

        void Relay(IAppMsg msg)
            => Next(msg);
              
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
    }   
}