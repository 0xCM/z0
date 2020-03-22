//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using Z0.Asm;

    public interface IImmCapture : IAsmService
    {
        AsmFunction Capture(in OpExtractExchange exchange, byte imm8);

        AsmFunction[] Capture(in OpExtractExchange exchange, params byte[] immediates)
        {
            var dst = new AsmFunction[immediates.Length];

            for(var i=0; i<dst.Length; i++)
                dst[i] = Capture(in exchange, immediates[i]);
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