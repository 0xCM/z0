//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;

    public static class SDel
    {
        [MethodImpl(Inline)]
        public static IBinaryOp<T> add<T>()
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

        [MethodImpl(Inline)]
        public static T apply<T>(AddOp<T> op, T x, T y)
            where T : unmanaged        
                => op.Invoke(x,y);

        [MethodImpl(Inline)]
        public static T apply<T>(SubOp<T> op, T x, T y)
            where T : unmanaged        
                => op.Invoke(x,y);

        [MethodImpl(Inline)]
        public static T apply<T>(MulOp<T> op, T x, T y)
            where T : unmanaged        
                => op.Invoke(x,y);

        [MethodImpl(Inline)]
        public static T apply<T>(DivOp<T> op, T x, T y)
            where T : unmanaged        
                => op.Invoke(x,y);

        [MethodImpl(Inline)]
        public static T apply<T>(ModOp<T> op, T x, T y)
            where T : unmanaged        
                => op.Invoke(x,y);

        [MethodImpl(Inline)]
        public static T apply<T>(AbsOp<T> op, T x)
            where T : unmanaged        
                => op.Invoke(x);

        [MethodImpl(Inline)]
        public static T apply<T>(IncOp<T> op, T x)
            where T : unmanaged        
                => op.Invoke(x);

        [MethodImpl(Inline)]
        public static T apply<T>(DecOp<T> op, T x)
            where T : unmanaged        
                => op.Invoke(x);

        [MethodImpl(Inline)]
        public static T apply<T>(NegateOp<T> op, T x)
            where T : unmanaged        
                => op.Invoke(x);

        [MethodImpl(Inline)]
        public static T apply<T>(NotOp<T> op, T x)
            where T : unmanaged        
                => op.Invoke(x);
    }

    public readonly struct AddOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {
        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.add(x,y);
    }

    public readonly struct SubOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {
        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.sub(x,y);
    }

    public readonly struct MulOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {    
        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.mul(x,y);
    }

    public readonly struct DivOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {
        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.div(x,y);
    }

    public readonly struct ModOp<T> : IBinaryOp<T>
        where T : unmanaged        
    {
        [MethodImpl(Inline)]
        public readonly T Invoke(T x, T y)
            => gmath.mod(x,y);
    }

   public readonly struct AbsOp<T>  : IUnaryOp<T>
        where T : unmanaged        
    {
        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.abs(x);
    }

    public readonly struct IncOp<T> : IUnaryOp<T>
        where T : unmanaged        
    {
        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.inc(x);
    }

    public readonly struct DecOp<T> : IUnaryOp<T>
        where T : unmanaged        
    {
        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.dec(x);
    }

    public readonly struct NegateOp<T> : IUnaryOp<T>
        where T : unmanaged        
    {
        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.negate(x);
    }

    public readonly struct NotOp<T> : IUnaryOp<T>
        where T : unmanaged        
    {
        [MethodImpl(Inline)]
        public readonly T Invoke(T x)
            => gmath.not(x);
    }    
}