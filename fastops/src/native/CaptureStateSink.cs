//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using System.Runtime.CompilerServices;
    using static zfunc;

    public interface ICaptureStateSink : IPointSink<CaptureState>
    {
        
    }

    public readonly struct CaptureStateSink : ICaptureStateSink
    {
        readonly IPointSink<CaptureState> Target;

        [MethodImpl(Inline)]
        public static ICaptureStateSink From(IPointSink<CaptureState> dst)
            => new CaptureStateSink(dst);

        
        [MethodImpl(Inline)]
        CaptureStateSink(IPointSink<CaptureState> target)            
        {
            this.Target = target;
        }
        
        [MethodImpl(Inline)]
        public void Accept(in CaptureState src)
            => Target.Accept(in src);
    }

}