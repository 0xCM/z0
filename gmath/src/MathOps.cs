//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public static partial class MathOps
    {
        [MethodImpl(Inline)]
        public static AddOp<T> add<T>()
            where T : unmanaged        
                => default(AddOp<T>);

        [MethodImpl(Inline)]
        public static SubOp<T> sub<T>()
            where T : unmanaged        
                => default;

        [MethodImpl(Inline)]
        public static MulOp<T> mul<T>()
            where T : unmanaged        
                => default;

        [MethodImpl(Inline)]
        public static DivOp<T> div<T>()
            where T : unmanaged        
                => default;

        [MethodImpl(Inline)]
        public static ModOp<T> mod<T>()
            where T : unmanaged        
                => default;

        [MethodImpl(Inline)]
        public static AbsOp<T> abs<T>()
            where T : unmanaged        
                => default;

        [MethodImpl(Inline)]
        public static IncOp<T> inc<T>()
            where T : unmanaged        
                => default;

        [MethodImpl(Inline)]
        public static DecOp<T> dec<T>()
            where T : unmanaged        
                => default;

        [MethodImpl(Inline)]
        public static NotOp<T> not<T>()
            where T : unmanaged        
                => default;

        [MethodImpl(Inline)]
        public static NegateOp<T> negate<T>()
            where T : unmanaged        
                => default;
    }






}