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
        public readonly struct V128x8i : IV128<V128x8i,sbyte>
        {            
            public Vector128<sbyte> Subject {get;}

            [MethodImpl(Inline)]
            public static implicit operator V128<sbyte>(V128x8i src)
                => src.ToGeneric();

            [MethodImpl(Inline)]
            public V128x8i(in Vector128<sbyte> subject)
            {
                this.Subject = subject;
            }            

            [MethodImpl(Inline)]
            public V128x8i New(in Vector128<sbyte> src)
                => new V128x8i(src);

            [MethodImpl(Inline)]
            public V128<sbyte> ToGeneric()
                => new V128<sbyte>(Subject);

            [MethodImpl(Inline)]
            public S Convert<S,T>(S model = default, T t = default)
                where S : struct, IV128<S,T>
                where T : unmanaged
                    => model.New(Subject.As<sbyte,T>());            


            public override string ToString()
                => this.Format();
        }
    }
}