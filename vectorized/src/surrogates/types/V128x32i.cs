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
        public readonly struct V128x32i : IV128<V128x32i,int>
        {            
            public Vector128<int> Subject {get;}                       

            [MethodImpl(Inline)]
            public V128x32i(in Vector128<int> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V128x32i New(in Vector128<int> src)
                => new V128x32i(src);

            [MethodImpl(Inline)]
            public V128<int> ToGeneric()
                => new V128<int>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV128<S,T>
                where T : unmanaged
                    => model.New(Subject.As<int,T>());

            public override string ToString()
                => this.Format();
        }
    }
}