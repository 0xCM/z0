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

    public interface IAsmEmissionToken : IEquatable<AsmEmissionToken>, IComparable<AsmEmissionToken>
    {

    }

    public interface IAsmEmissionSink : IPointSink<AsmEmissionGroup>
    {
        
    }

    public interface ICaptureJunction
    {
        void Accept(in CaptureExchange exchange, in CaptureState state);   

        void Complete(in CaptureExchange exchange, in CapturedMember captured);        
    }

    public interface ICaptureEventSink
    {
        void Accept(in CaptureEventInfo info);

        void Complete(in CapturedMember captured){}
    }

    public interface ICaptureOps
    {               
        CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, MethodInfo src);            

        CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, in DynamicDelegate src);
            
        CapturedMember Capture(in CaptureExchange exchange, in OpIdentity id, Delegate src);
            
        Option<CapturedOpData> Capture(in CaptureExchange exchange, in OpIdentity id, Span<byte> src);
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
}