//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.InteropServices;

    using static Root;

    partial class VectorSurrogates
    {
        [StructLayout(LayoutKind.Sequential, Size = 32)]
        public readonly struct V256x64u : IV256<V256x64u,ulong>
        {            
            public Vector256<ulong> Subject {get;}        

            [MethodImpl(Inline)]
            public static implicit operator V256<ulong>(V256x64u src)
                => src.ToGeneric();

            [MethodImpl(Inline)]
            public V256x64u(in Vector256<ulong> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V256x64u New(in Vector256<ulong> src)
                => new V256x64u(src);

            [MethodImpl(Inline)]
            public V256<ulong> ToGeneric()
                => new V256<ulong>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV256<S,T>
                where T : unmanaged
                    => model.New(Subject.As<ulong,T>());            
 
            public override string ToString()
                => this.Format();
       }
    }
}