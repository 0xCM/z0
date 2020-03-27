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
        public readonly struct V128x64i : IV128<V128x64i,long>
        {
            public Vector128<long> Subject {get;}                       
            
            [MethodImpl(Inline)]
            public V128x64i(Vector128<long> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V128x64i New(in Vector128<long> src)
                => new V128x64i(src);

            [MethodImpl(Inline)]
            public V128<long> ToGeneric()
                => new V128<long>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV128<S,T>
                where T : unmanaged
                    => model.New(Subject.As<long,T>());            

            public override string ToString()
                => this.Format();

        }
    }
}