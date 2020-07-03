//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;


    using static Konst;


    public interface INumericKind : IKind, ILiteralKind<NumericKind>
    {
        
    }

    public interface INumericKind<T> : INumericKind
        where T : unmanaged
    {
        TypeWidth Width 
            => (TypeWidth)(Unsafe.SizeOf<T>()*8);            
                
        NumericKind ITypedLiteral<NumericKind>.Class 
            => nkind<T>();
    }
}