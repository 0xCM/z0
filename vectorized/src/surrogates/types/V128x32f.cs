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
        public readonly struct V128x32f : IV128<V128x32f,float>
        {
            public Vector128<float> Subject {get;}                       
            
            [MethodImpl(Inline)]
            public static implicit operator V128<float>(V128x32f src)
                => src.ToGeneric();
            
            [MethodImpl(Inline)]
            public V128x32f(Vector128<float> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V128x32f New(in Vector128<float> src)
                => new V128x32f(src);

            [MethodImpl(Inline)]
            public V128<float> ToGeneric()
                => new V128<float>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV128<S,T>
                where T : unmanaged
                    => model.New(Subject.As<float,T>());            

            public override string ToString()
                => this.Format();

        }
    }
}