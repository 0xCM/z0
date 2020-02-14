//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    partial class Fixed
    {

        // [MethodImpl(Inline)]
        // public static F Emit<T,F,E>(E emitter, F f = default, T t = default)
        //     where F : unmanaged, IFixed
        //     where T : struct
        //     where E : IEmitter<T>
        //         => FixedConvert.From<T,F>(emitter.Invoke());
        
        // [MethodImpl(Inline)]
        // public static F emit<T,F>(in EmitterSurrogate<T> src)
        //     where F : unmanaged, IFixed
        //     where T : struct
        //         => FixedConvert.From<T,F>(src.Invoke());

        // [MethodImpl(Inline)]
        // public static F emit<T,F>(Emitter<T> src)
        //     where F : unmanaged, IFixed
        //     where T : struct
        //         => FixedConvert.From<T,F>(src());

    }
}
