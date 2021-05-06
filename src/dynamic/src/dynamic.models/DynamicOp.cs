//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Emit;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct DynamicOp
    {
        public Type DelegateType {get;}

        public DynamicMethod Definition {get;}

        public Delegate Delegate {get;}


        [MethodImpl(Inline)]
        public DynamicOp(DynamicMethod src, Delegate del, Type type)
        {
            DelegateType = type;
            Definition = src;
            Delegate = del;
        }
    }

    public readonly struct DynamicOp<D>
        where D : Delegate
    {
        public DynamicMethod Definition {get;}

        public D Delegate {get;}

        [MethodImpl(Inline)]
        public DynamicOp(DynamicMethod src, D @delegate)
        {
            Definition = src;
            Delegate = @delegate;
        }

        [MethodImpl(Inline)]
        public static implicit operator DynamicOp(DynamicOp<D> src)
            => new DynamicOp(src.Definition, src.Delegate, typeof(D));

        [MethodImpl(Inline)]
        public static implicit operator DynamicOp<D>((DynamicMethod def, D @delegate) src)
            => new DynamicOp<D>(src.def, src.@delegate);
    }
}