//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;

    public interface INativeCaptureSvc
    {


    }
    
    readonly struct NativeCaptureSvc : INativeCaptureSvc
    {
        readonly byte[] buffer; 
                
        public static INativeCaptureSvc Create(int? buffersize = null)
            => default(NativeCaptureSvc);

        public static INativeCaptureSvc Create(byte[] buffer)
            => default(NativeCaptureSvc);

        NativeCaptureSvc(byte[] buffer)
        {
            this.buffer = buffer;
        }

        NativeCaptureSvc(int? buffersize)
        {
            buffer = new byte[buffersize ?? NativeReader.DefaultBufferLen];
        }


        Span<byte> TakeBuffer()
        {
            buffer.Clear();
            return buffer;
        }   

        /// <summary>
        /// Captures native code produced by the JIT for a dynamic delegate
        /// </summary>
        /// <param name="d">The dynamic delegate</param>
        /// <param name="dst">The target buffer</param>
        public unsafe MemberCapture Capture(Moniker id, DynamicDelegate d)
            => NativeReader.read(id,d,TakeBuffer());

    }

}