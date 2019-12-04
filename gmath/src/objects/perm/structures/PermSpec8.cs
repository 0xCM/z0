//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    [StructLayout(LayoutKind.Sequential, Size = 32)]
    public ref struct Perm8Spec
    {
        Span<Perm8> terms;

        public static Perm8Spec Identity 
        {
            [MethodImpl(Inline)]
            get => new Perm8Spec(Perm8.A, Perm8.B, Perm8.C, Perm8.D, Perm8.E, Perm8.F, Perm8.G, Perm8.H);
        }

        [MethodImpl(Inline)]
        Perm8Spec(params Perm8[] terms)
            => this.terms = terms;

        [MethodImpl(Inline)]
        Perm8Spec(Span<Perm8> terms)
            => this.terms = terms;

        public ref Perm8 this[Perm8 index]
        {
            [MethodImpl(Inline)]
            get => ref seek(ref head(terms), (int)index);
        }

        [MethodImpl(Inline)]
        public Perm8Spec Replicate()
            => new Perm8Spec(terms.Replicate());

        [MethodImpl(Inline)]        
        public Span<T> AsSpan<T>()
            where T : unmanaged
                => terms.As<Perm8, T>();
    }
}