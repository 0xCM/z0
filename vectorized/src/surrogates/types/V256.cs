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
        public readonly struct V256<T> : IV256<V256<T>,T>
            where T : unmanaged
        {
            public Vector256<T> Subject {get;}

            [MethodImpl(Inline)]
            public V256(Vector256<T> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public bool Equals(V256<T> src)          
                => src.Subject.Equals(Subject);

            [MethodImpl(Inline)]
            public V256<S> As<S>()
                where S : unmanaged 
                    => new V256<S>(Subject.As<T,S>());

            [MethodImpl(Inline)]
            public V256<T> New(in Vector256<T> src)
                => new V256<T>(src);


            [MethodImpl(Inline)]
            public S Convert<S,U>(S model = default, U t = default)
                where S : struct, IV256<S,U>
                where U : unmanaged
                    => model.New(Subject.As<T,U>());

            public override string ToString()
                => this.Format();

        }
    }
}