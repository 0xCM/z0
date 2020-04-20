//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections.Generic;
    
    using static Seed;
    using static Memories;

    public class AsmContext : IAsmContext 
    {            
        public event Action<IAppMsg> Next;

        public IPolyrand Random {get;}

        public IAppMsgQueue Queue {get;}
        
        public IAppSettings Settings {get;}

        public AsmFormatConfig AsmFormat {get;}

        public FolderPath RootCapturePath {get;}

        public IApiSet ApiSet {get;}

        public IAppPaths AppPaths {get;}

        public IAsmFormatter Formatter {get;}
        
        public IAsmFunctionDecoder Decoder {get;}

        public ICaptureService CaptureService {get;}

        public ICaptureControl CaptureControl {get;}
        
        public IDynamicOps Dynamic {get;}

        public static IAsmContext Create(IAppSettings settings, IAppMsgQueue queue, IApiComposition api, FolderPath root, AsmFormatConfig format = null)
        {
            var context = IContext.Default;
            var random = Polyrand.Pcg64(PolySeed64.Seed05);                
            var _format = format ?? AsmFormatConfig.New;
            var decoder = AsmDecoder.function(context, _format);
            var formatter = AsmDecoder.formatter(context, _format);
            var factory = AsmDecoder.writerFactory(context);
            var capture = context.Capture();
            var control =  MemberCaptureControl.Create(context, capture);
            var dynops = context.Dynamic();
            return AsmContext.Create(settings, queue, api, root, random, _format, formatter, decoder, factory, capture, control,dynops);
        }

        /// <summary>
        /// Creates a base context with a specified composition
        /// </summary>
        /// <param name="assemblies">A composition of assemblies to share with the context</param>
        public static IAsmContext Create(
            IAppSettings settings, 
            IAppMsgQueue queue, 
            IApiComposition assemblies, 
            FolderPath root,            
            IPolyrand random, 
            AsmFormatConfig format,
            IAsmFormatter formatter,
            IAsmFunctionDecoder decoder,
            AsmWriterFactory writerFactory,
            ICaptureService capture,
            ICaptureControl control,
            IDynamicOps dynops)
                => new AsmContext(assemblies, settings, queue, root, random, format, formatter, 
                    decoder, writerFactory, capture,control, dynops);

        AsmContext(
            IApiComposition composition, 
            IAppSettings settings, 
            IAppMsgQueue queue, 
            FolderPath root,            
            IPolyrand random, 
            AsmFormatConfig format,
            IAsmFormatter formatter,
            IAsmFunctionDecoder decoder,
            AsmWriterFactory writerFactory,
            ICaptureService capture,
            ICaptureControl control,
            IDynamicOps dynops
            )
        {
            Next += BlackHole;
            Queue = queue;
            Settings = settings;
            Queue.Next += Relay;      
            RootCapturePath = root;      
            Random = random;
            AsmFormat = format;
            Settings = settings;
            AppPaths = IAppPaths.Default;
            ApiSet = composition.ApiSet();
            Formatter = formatter;
            Decoder = decoder;
            WriterFactory = writerFactory;   
            CaptureService = capture;         
            CaptureControl = control;
            Dynamic = dynops;
        }
        
        AsmWriterFactory WriterFactory {get;}

        public IAsmFunctionWriter Writer(FilePath dst)
            => WriterFactory(dst, Formatter);

        public void Deposit(IAppMsg msg)
            => Queue.Deposit(msg);

        public void Notify(string msg, AppMsgKind? severity = null)
            => Queue.Notify(msg, severity);

        public IReadOnlyList<IAppMsg> Dequeue()
            => Queue.Dequeue();

        public IReadOnlyList<IAppMsg> Flush(Exception e)
            => Queue.Flush(e);

        public void Emit(FilePath dst) 
            => Queue.Emit(dst);

        void BlackHole(IAppMsg msg) {}

        void Relay(IAppMsg msg)
            => Next(msg);
    }   
}