//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    public interface INumericKind : ILiteralKind<NumericKind>
    {

    }

    public interface INumericKind<T> : INumericKind
        where T : unmanaged
    {
        TypeWidth Width
            => (TypeWidth)(Unsafe.SizeOf<T>()*8);

        NumericKind ITypedLiteral<NumericKind>.Class
            => NumericKinds.kind<T>();
    }

    public interface INumericKind<F,T> : INumericKind<T>
        where F : unmanaged, INumericKind<F,T>
        where T : unmanaged
    {

    }
}