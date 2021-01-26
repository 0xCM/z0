//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    [ApiHost]
    public sealed class VSvcValidator : ApiValidator<VSvcValidator>
    {
        const NumericKind Closure = UnsignedInts;

        public override void Validate()
        {
            var lhs = Source.Cells<Cell128>(SampleCount);
            var rhs = Source.Cells<Cell128>(SampleCount);
            Check(lhs,rhs);
        }

        [Op]
        void Check(Index<Cell128> lhs, Index<Cell128> rhs)
        {
            for(var i=0; i<SampleCount; i++)
            {
                ref readonly var a = ref lhs[i];
                ref readonly var b = ref rhs[i];
                var f = BitLogicKinds.and();
                Check128x8u(a, b, f);
                Check128x8i(a, b, f);
                Check128x16u(a, b, f);
                Check128x16i(a, b, f);
            }
        }

        [MethodImpl(Inline)]
        bit Check128x8u<K>(Vector128<byte> a, Vector128<byte> b, K f)
            where K : unmanaged, IBitLogicKind
        {
            return CheckMatch(a,b,f);
        }

        [MethodImpl(Inline)]
        bit Check128x8i<K>(Vector128<sbyte> a, Vector128<sbyte> b, K f)
            where K : unmanaged, IBitLogicKind
        {
           return CheckMatch(a,b,f);
        }

        [MethodImpl(Inline)]
        bit Check128x16u<K>(Vector128<ushort> a, Vector128<ushort> b, K f)
            where K : unmanaged, IBitLogicKind
        {
            return CheckMatch(a,b,f);
        }

        [MethodImpl(Inline)]
        bit Check128x16i<K>(Vector128<short> a, Vector128<short> b, K f)
            where K : unmanaged, IBitLogicKind
        {
            return CheckMatch(a,b,f);
        }

        [MethodImpl(Inline)]
        bit CheckMatch<K,T>(Vector128<T> x, Vector128<T> y, K f = default)
            where K : unmanaged, IBitLogicKind
            where T : unmanaged
        {
            var w = w128;
            var mSvc = MSvc.bitlogic<T>();
            var vSvc = VSvc.vbitlogic<T>(w);
            var buffer = Cells.alloc(w);
            ref var dst = ref Cells.first<T>(buffer);
            var cells = gcpu.vcount<T>(w);
            for(byte i=0; i<cells; i++)
                seek(dst, i) = mSvc.eval(vcell(x,i), vcell(y,i), f);
            var v1 = gcpu.vload(w, dst);
            var v2 = vSvc.eval(x,y,f);
            return gvec.vsame(v2,v1);
        }

        [MethodImpl(Inline)]
        bit CheckMatch<K,T>(Vector256<T> x, Vector256<T> y, K f)
            where K : unmanaged, IBitLogicKind
            where T : unmanaged
        {
            var w = w256;
            var mSvc = MSvc.bitlogic<T>();
            var vSvc = VSvc.vbitlogic<T>(w);
            var buffer = Cells.alloc(w);
            ref var dst = ref Cells.first<T>(buffer);
            var cells = gcpu.vcount<T>(w);
            for(byte i=0; i<cells; i++)
                seek(dst, i) = mSvc.eval(vcell(x,i), vcell(y,i), f);
            var v1 = gcpu.vload(w, dst);
            var v2 = vSvc.eval(x,y,f);
            return gvec.vsame(v2,v1);
        }
    }
}