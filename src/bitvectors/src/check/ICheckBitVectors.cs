//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;
    using static AppErrorMsg;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public readonly struct CheckBitThings : ICheckBitThings, IValidator<CheckBitThings,ICheckBitThings>
    {        
        public static ICheckBitThings Checker => default(CheckBitThings);         
    }

    public interface ICheckBit : IValidator
    {
        [MethodImpl(Inline)]
        bool eq(bit lhs, bit rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs == rhs ? true : throw failed(ClaimKind.Eq, NotEqual(lhs, rhs, caller, file, line));

        [MethodImpl(Inline)]
        bool neq(bit lhs, bit rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => lhs != rhs ? true : throw failed(ClaimKind.NEq, Equal(lhs, rhs, caller, file, line));
    }

    public interface ICheckBitThings : ICheckBitVectors, ICheckBitStrings, ICheckInvariant, ICheckNumeric, ICheckPrimalSeq, ICheckVectors
    {
            
    }

    public readonly struct CheckBitVectors : ICheckBitVectors
    {
        public static ICheckBitVectors Checker => default(CheckBitVectors);
    }

    public interface ICheckBitVectors : ICheckPrimal, ICheckInvariant
    {        
        ICheckPrimal Primal => this;

        [MethodImpl(Inline)]
        void eq(BitVector4 x, BitVector4 y, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Primal.eq(x.Scalar, y.Scalar, caller, file, line);

        [MethodImpl(Inline)]
        void eq(BitVector8 x, BitVector8 y, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Primal.eq(x.Scalar, y.Scalar, caller, file, line);

        [MethodImpl(Inline)]
        void eq(BitVector16 x, BitVector16 y, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Primal.eq(x.Scalar, y.Scalar, caller, file, line);

        [MethodImpl(Inline)]
        void eq(BitVector32 x, BitVector32 y, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Primal.eq(x.Scalar, y.Scalar, caller, file, line);

        [MethodImpl(Inline)]
        void eq(BitVector64 x, BitVector64 y, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Primal.eq(x.Scalar, y.Scalar, caller, file, line);       

        [MethodImpl(Inline)]
        void eq<T>(BitVector<T> x, BitVector<T> y, [Caller] string caller = null, [File] string file = null, [Line] int? line = null) 
            where T : unmanaged
                => yea(gmath.eq(x.Scalar, y.Scalar), $"{x} != {y}", caller, file, line);

        [MethodImpl(Inline)]
        void eq<N,T>(BitVector128<N,T> x, BitVector128<N,T> y, [Caller] string caller = null, [File] string file = null, [Line] int? line = null) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => yea(x.Equals(y), $"{x} != {y}", caller, file, line);

        [MethodImpl(Inline)]
        void eq<N,T>(BitVector<N,T> x, BitVector<N,T> y, [Caller] string caller = null, [File] string file = null, [Line] int? line = null) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => yea(x.Equals(y), $"{x} != {y}", caller, file, line);
    }
   
}