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
        public readonly struct V128x64u : IV128<V128x64u,ulong>
        {            
            public Vector128<ulong> Subject {get;}        

            [MethodImpl(Inline)]
            public static implicit operator V128<ulong>(V128x64u src)
                => src.ToGeneric();

            [MethodImpl(Inline)]
            public V128x64u(in Vector128<ulong> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V128x64u New(in Vector128<ulong> src)
                => new V128x64u(src);

            [MethodImpl(Inline)]
            public V128<ulong> ToGeneric()
                => new V128<ulong>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV128<S,T>
                where T : unmanaged
                    => model.New(Subject.As<ulong,T>());            
 
            public override string ToString()
                => this.Format();
       }
    }
}