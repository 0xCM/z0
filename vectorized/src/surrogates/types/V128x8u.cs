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
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public readonly struct V128x8u : IV128<V128x8u,byte>
        {
            public Vector128<byte> Subject {get;}       

            [MethodImpl(Inline)]
            public static implicit operator V128<byte>(V128x8u src)
                => src.ToGeneric();

            [MethodImpl(Inline)]
            public V128x8u(Vector128<byte> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V128x8u New(in Vector128<byte> src)
                => new V128x8u(src);

            [MethodImpl(Inline)]
            public V128<byte> ToGeneric()
                => new V128<byte>(Subject);        

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV128<S,T>
                where T : unmanaged
                    => model.New(Subject.As<byte,T>());

            public override string ToString()
                => this.Format();
        }
    }
}