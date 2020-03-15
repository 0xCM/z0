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
        public readonly struct V128x16i : IV128<V128x16i,short>
        {       
            public Vector128<short> Subject {get;}   

            [MethodImpl(Inline)]
            public static implicit operator V128<short>(V128x16i src)
                => src.ToGeneric();

            [MethodImpl(Inline)]
            public V128x16i(Vector128<short> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V128x16i New(in Vector128<short> src)
                => new V128x16i(src);

            [MethodImpl(Inline)]
            public V128<short> ToGeneric()
                => new V128<short>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV128<S,T>
                where T : unmanaged
                    => model.New(Subject.As<short,T>());            

            public override string ToString()
                => this.Format();
        }
    }
}