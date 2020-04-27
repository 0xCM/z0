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
        public static IAsmContext Create(IAppSettings settings, IAppMsgQueue queue, IApiComposition composition,
             FolderPath root = null, in AsmFormatSpec? format = null)
                => new AsmContext(settings,queue, composition, root ?? Env.Current.LogDir, format ?? AsmFormatSpec.DefaultStreamFormat);

        public event Action<IAppMsg> Next;

        public IPolyrand Random {get;}

        public IAppMsgQueue Queue {get;}
        
        public IAppSettings Settings {get;}

        public AsmFormatSpec AsmFormat {get;}

        public FolderPath RootCapturePath {get;}

        public IApiSet ApiSet {get;}

        public IAppPaths AppPaths {get;}

        public IAsmFormatter Formatter {get;}
        
        public IAsmFunctionDecoder Decoder {get;}

        public ICaptureService CaptureService {get;}

        public ICaptureControl CaptureControl {get;}
        
        public IDynexus Dynamic {get;}

        public IImmSpecializer ImmServices {get;}

        AsmContext(IAppSettings settings, IAppMsgQueue queue, IApiComposition composition, FolderPath root, in AsmFormatSpec format)
        {
            Next  = e => {};
            AppPaths = Z0.AppPaths.Default;

            Settings = settings;
            Queue = queue;
            Queue.Next += Relay;      
            ApiSet = composition.ApiSet();
            RootCapturePath = root;      
            AsmFormat = format;

            Random = Polyrand.Pcg64(PolySeed64.Seed05);

            var factory = AsmStatelessCore.Factory;

            var context = IContext.Default;
            Decoder = factory.FunctionDecoder(AsmFormat);
            Formatter  = factory.AsmFormatter(AsmFormat);
            WriterFactory = factory.AsmWriterFactory;
            CaptureService =  factory.CaptureService();
            CaptureControl =  factory.CaptureControl(CaptureService);
            Dynamic = Dynops.Services.Nexus;
            ImmServices = ImmSpecializer.Create(context, Decoder);
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

        void Relay(IAppMsg msg)
            => Next(msg);
    }   
}