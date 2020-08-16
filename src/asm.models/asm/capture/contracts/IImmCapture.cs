//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using Z0.Asm;
    
    using static Konst;

    public interface IImmCapture : IService
    {
        Option<AsmRoutine> Capture(in CaptureExchange exchange, byte imm8);

        AsmRoutine[] Capture(in CaptureExchange exchange, params byte[] immediates)
        {
            var dst = new AsmRoutine[immediates.Length];

            for(var i=0; i<dst.Length; i++)
            {
                var cap = Capture(exchange, immediates[i]).OnNone(()=> term.error($"Capture failure")); 
                dst[i] = cap ? cap.Value : AsmRoutine.Empty;
            }
            return dst;
        }                    
    }

    public interface IImmCapture<T> : IImmCapture
        where T : unmanaged
    {

    }

    public interface IImmUnaryCapture<T> : IImmCapture<T>, IImmCapture
        where T : unmanaged
    {
    }

    public interface IImmBinaryCapture<T> : IImmCapture<T>,  IImmCapture
        where T : unmanaged        
    {
    }
}