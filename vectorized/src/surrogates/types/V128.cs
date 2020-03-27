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
        [StructLayout(LayoutKind.Sequential, Size = 16)]
        public readonly struct V128<T> : IV128<V128<T>, T>
            where T : unmanaged
        {
            public Vector128<T> Subject {get;}

            [MethodImpl(Inline)]
            public V128(Vector128<T> subject)
            {
                this.Subject = subject;
            }  

            [MethodImpl(Inline)]
            public bool Equals(V128<T> src)          
                => src.Subject.Equals(Subject);
            
            [MethodImpl(Inline)]
            public V128<S> As<S>()
                where S : unmanaged      
                    => new V128<S>(Subject.As<T,S>());

            [MethodImpl(Inline)]
            public V128<T> New(in Vector128<T> src)
                => new V128<T>(src);

            [MethodImpl(Inline)]
            public S Convert<S,U>(S model = default, U t = default)
                where S : struct, IV128<S,U>
                where U : unmanaged
                    => model.New(Subject.As<T,U>());

            public override string ToString()
                => this.Format();
        }
    }
}