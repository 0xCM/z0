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

    using static Core;

    partial class VectorSurrogates
    {
        [StructLayout(LayoutKind.Sequential, Size = 32)]
        public readonly struct V256x32u : IV256<V256x32u,uint>
        {
            public Vector256<uint> Subject {get;}                       
            
            [MethodImpl(Inline)]
            public static implicit operator V256<uint>(V256x32u src)
                => src.ToGeneric();
            
            [MethodImpl(Inline)]
            public V256x32u(Vector256<uint> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V256x32u New(in Vector256<uint> src)
                => new V256x32u(src);

            [MethodImpl(Inline)]
            public V256<uint> ToGeneric()
                => new V256<uint>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV256<S,T>
                where T : unmanaged
                    => model.New(Subject.As<uint,T>());            

            public override string ToString()
                => this.Format();

        }
    }
}