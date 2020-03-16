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
    using static Nats;

    partial class VectorSurrogates
    {
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public readonly struct V128x64f : IV128<V128x64f,double>
        {
            public Vector128<double> Subject {get;}                       
            
            [MethodImpl(Inline)]
            public static implicit operator V128<double>(V128x64f src)
                => src.ToGeneric();
            
            [MethodImpl(Inline)]
            public V128x64f(Vector128<double> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V128x64f New(in Vector128<double> src)
                => new V128x64f(src);

            [MethodImpl(Inline)]
            public V128<double> ToGeneric()
                => new V128<double>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV128<S,T>
                where T : unmanaged
                    => model.New(Subject.As<double,T>());            

            public override string ToString()
                => this.Format();

        }
    }
}