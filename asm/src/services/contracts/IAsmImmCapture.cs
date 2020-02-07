//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using Z0.AsmSpecs;

    using static zfunc;

    public interface IAsmImmCapture
    {
        AsmFunction Capture(in CaptureExchange exchange, byte imm8);

        AsmFunction[] Capture(in CaptureExchange exchange, params byte[] immediates)
        {
            var dst = new AsmFunction[immediates.Length];

            for(var i=0; i<dst.Length; i++)
                dst[i] = Capture(in exchange, immediates[i]);
            return dst;
        }            
        
    }

    public interface IAsmImmCapture<T> : IAsmImmCapture
        where T : unmanaged
    {

    }

    public interface IAsmImmUnaryCapture : IAsmImmCapture
    {
        
    }    

    public interface IAsmImmBinaryCapture : IAsmImmCapture
    {        
                
    }    

    public interface IAsmImmUnaryCapture<T> : IAsmImmCapture<T>, IAsmImmUnaryCapture
        where T : unmanaged        
    {
    }

    public interface IAsmImmBinaryCapture<T> : IAsmImmCapture<T>,  IAsmImmBinaryCapture
        where T : unmanaged        
    {
    }
}