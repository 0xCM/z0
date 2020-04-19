//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface IBitVectorCheck : ICheckPrimal
    {        
        ICheckPrimal Primal => this;

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
    }
    
    public readonly struct BitVectorCheck : IBitVectorCheck
    {

    }
}