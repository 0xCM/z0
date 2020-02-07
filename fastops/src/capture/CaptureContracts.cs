//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface ICaptureJunction
    {
        void Accept(in CaptureState state, in CaptureExchange exchange);   

        void Complete(in CapturedMember captured, in CaptureExchange exchange);
        
    }

    public interface ICaptureEventSink
    {
        void Accept(in CaptureEventInfo info);

        void Complete(in CapturedMember captured){}
    }

    public interface ICaptureOps
    {
        CapturedMember Capture(OpIdentity id, MethodInfo method, in CaptureExchange exchange);        
        
        CapturedMember Capture(OpIdentity id, DynamicDelegate src, in CaptureExchange exchange);

        CapturedMember Capture(OpIdentity id, Delegate src, in CaptureExchange exchange);


        CapturedMember Capture(MethodInfo method, in CaptureExchange exchange)
            => Capture(method.Identify(), method, exchange);
    }

    public interface ICaptureControl : ICaptureOps, ICaptureJunction, ICaptureEventSink
    {

    }

    public interface ICaptureWriter : IDisposable
    {
        void WriteHeader();

        void WriteData(CapturedMember src);        
    
        void WriteData(CapturedMember src, HexLineFormat config);     

        void WriteLine(string data);   

        byte[] TakeBuffer();        
    }

    public interface ICaptureService : ICaptureOps
    {        
        CapturedMember Capture(OpIdentity id, DynamicDelegate src, Span<byte> dst)
            => Capture(id,src,CaptureExchange.Define(dst));

        CapturedMember Capture(OpIdentity id, Delegate src, Span<byte> dst)
            => Capture(id,src,CaptureExchange.Define(dst));

        CapturedMember Capture(MethodInfo src, Span<byte> dst)
            => Capture(src.Identify(),src, CaptureExchange.Define(dst));

        CapturedMember Capture(OpIdentity id, MethodInfo src, Span<byte> dst)
            => Capture(id,src, CaptureExchange.Define(dst));
 
        CapturedMember Capture(MethodInfo src, Type[] args, Span<byte> dst)
            => Capture(src.CloseGenericMethod(args), dst);

        void Capture(Delegate src, ICaptureWriter dst) 
            => dst.WriteData(Capture(src.Identify(), src, dst.TakeBuffer()));           

        void Capture(MethodInfo src, ICaptureWriter dst)
            => dst.WriteData(Capture(src.Identify(), src,dst.TakeBuffer()));
    }
}