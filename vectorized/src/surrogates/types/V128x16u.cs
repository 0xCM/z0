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
        public readonly struct V128x16u : IV128<V128x16u,ushort>
        {
            public Vector128<ushort> Subject {get;}                       
            
            [MethodImpl(Inline)]
            public static implicit operator V128<ushort>(V128x16u src)
                => src.ToGeneric();

            [MethodImpl(Inline)]
            public V128x16u(Vector128<ushort> subject)
            {
                this.Subject = subject;
            }            
     
            [MethodImpl(Inline)]
            public V128x16u New(in Vector128<ushort> src)
                => new V128x16u(src);

            [MethodImpl(Inline)]
            public V128<ushort> ToGeneric()
                => new V128<ushort>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV128<S,T>
                where T : unmanaged
                    => model.New(Subject.As<ushort,T>());

            public override string ToString()
                => this.Format();
        }
    }
}