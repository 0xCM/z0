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
        [StructLayout(LayoutKind.Sequential, Size = 32)]
        public readonly struct V256x64i : IV256<V256x64i,long>
        {
            public Vector256<long> Subject {get;}                       
            
            [MethodImpl(Inline)]
            public V256x64i(Vector256<long> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V256x64i New(in Vector256<long> src)
                => new V256x64i(src);

            [MethodImpl(Inline)]
            public V256<long> ToGeneric()
                => new V256<long>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV256<S,T>
                where T : unmanaged
                    => model.New(Subject.As<long,T>());            

            public override string ToString()
                => this.Format();

        }
    }
}