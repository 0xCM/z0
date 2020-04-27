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
             FolderPath root = null, AsmFormatConfig format = null)
                => new AsmContext(settings,queue, composition, root ?? Env.Current.LogDir, format ?? AsmFormatConfig.DefaultStreamFormat);

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

        public IImmSpecializer ImmServices {get;}

        AsmContext(IAppSettings settings, IAppMsgQueue queue, IApiComposition composition, FolderPath root, AsmFormatConfig format)
        {
            Next  = e => {};
            AppPaths = Z0.AppPaths.Default;

            Settings = settings;
            Queue = queue;
            Queue.Next += Relay;      
            ApiSet = composition.ApiSet();
            RootCapturePath = root;      
            AsmFormat = format;

            var context = IContext.Default;
            Random = Polyrand.Pcg64(PolySeed64.Seed05);
            Decoder = AsmDecoder.FunctionDecoder(AsmFormat);
            Formatter  = AsmServices.AsmFormatter(AsmFormat);
            WriterFactory = AsmServices.AsmWriterFactory;
            CaptureService = context.Capture();
            CaptureControl =  MemberCaptureControl.Create(context, CaptureService);
            Dynamic = context.Dynamic();
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