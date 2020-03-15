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
        public readonly struct V128x32u : IV128<V128x32u,uint>
        {
            public Vector128<uint> Subject {get;}                       
            
            [MethodImpl(Inline)]
            public static implicit operator V128<uint>(V128x32u src)
                => src.ToGeneric();
            
            [MethodImpl(Inline)]
            public V128x32u(Vector128<uint> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V128x32u New(in Vector128<uint> src)
                => new V128x32u(src);

            [MethodImpl(Inline)]
            public V128<uint> ToGeneric()
                => new V128<uint>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV128<S,T>
                where T : unmanaged
                    => model.New(Subject.As<uint,T>());            

            public override string ToString()
                => this.Format();

        }
    }
}