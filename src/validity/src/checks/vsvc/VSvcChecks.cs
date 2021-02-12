//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;
    using static cpu;

    using K = ApiClasses;

    [ApiHost]
    public sealed class VSvcValidator : ApiValidator<VSvcValidator>
    {
        const NumericKind Closure = UnsignedInts;

        public override void Validate()
        {
            Check128();

        }

        void Check128()
        {
            var lhs = Source.Cells<Cell128>(SampleCount);
            var rhs = Source.Cells<Cell128>(SampleCount);
            Check(lhs,rhs);
        }

        void Check256()
        {
            var lhs = Source.Cells<Cell256>(SampleCount);
            var rhs = Source.Cells<Cell256>(SampleCount);
            Check(lhs,rhs);
        }

        [Op]
        void Check(Index<Cell128> lhs, Index<Cell128> rhs)
        {
            for(var i=0; i<SampleCount; i++)
            {
                ref readonly var a = ref lhs[i];
                ref readonly var b = ref rhs[i];

                Check128x8u(a, b, K.and());
                // Check128x8i(a, b, BitLogicKinds.and());
                // Check128x16u(a, b, BitLogicKinds.and());
                // Check128x16i(a, b, BitLogicKinds.and());
                // Check128x32u(a, b, BitLogicKinds.and());
                // Check128x32i(a, b, BitLogicKinds.and());
                // Check128x64u(a, b, BitLogicKinds.and());
                // Check128x64i(a, b, BitLogicKinds.and());

                // Check128x8u(a, b, BitLogicKinds.or());
                // Check128x8i(a, b, BitLogicKinds.or());
                // Check128x16u(a, b, BitLogicKinds.or());
                // Check128x16i(a, b, BitLogicKinds.or());
                // Check128x32u(a, b, BitLogicKinds.or());
                // Check128x32i(a, b, BitLogicKinds.or());
                // Check128x64u(a, b, BitLogicKinds.or());
                // Check128x64i(a, b, BitLogicKinds.or());

                // Check128x8u(a, b, BitLogicKinds.xor());
                // Check128x8i(a, b, BitLogicKinds.xor());
                // Check128x16u(a, b, BitLogicKinds.xor());
                // Check128x16i(a, b, BitLogicKinds.xor());
                // Check128x32u(a, b, BitLogicKinds.xor());
                // Check128x32i(a, b, BitLogicKinds.xor());
                // Check128x64u(a, b, BitLogicKinds.xor());
                // Check128x64i(a, b, BitLogicKinds.xor());
            }
        }

        [Op]
        void Check(Index<Cell256> lhs, Index<Cell256> rhs)
        {
            for(var i=0; i<SampleCount; i++)
            {
                ref readonly var a = ref lhs[i];
                ref readonly var b = ref rhs[i];
                Check256x8u(a, b, K.and());
                Check256x8i(a, b, K.and());
                Check256x16u(a, b, K.and());
                Check256x16i(a, b, K.and());
                Check256x32u(a, b, K.and());
                Check256x32i(a, b, K.and());
                Check256x64u(a, b, K.and());
                Check256x64i(a, b, K.and());

                Check256x8u(a, b, K.or());
                Check256x8i(a, b, K.or());
                Check256x16u(a, b, K.or());
                Check256x16i(a, b, K.or());
                Check256x32u(a, b, K.or());
                Check256x32i(a, b, K.or());
                Check256x64u(a, b, K.or());
                Check256x64i(a, b, K.or());
            }
        }

        [MethodImpl(Inline)]
        bit Check128x8u<K>(Vector128<byte> a, Vector128<byte> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check128x8i<K>(Vector128<sbyte> a, Vector128<sbyte> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check128x16u<K>(Vector128<ushort> a, Vector128<ushort> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check128x16i<K>(Vector128<short> a, Vector128<short> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check128x32u<K>(Vector128<uint> a, Vector128<uint> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check128x32i<K>(Vector128<int> a, Vector128<int> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check128x64u<K>(Vector128<ulong> a, Vector128<ulong> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check128x64i<K>(Vector128<long> a, Vector128<long> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check256x8u<K>(Vector256<byte> a, Vector256<byte> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check256x8i<K>(Vector256<sbyte> a, Vector256<sbyte> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check256x16u<K>(Vector256<ushort> a, Vector256<ushort> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check256x16i<K>(Vector256<short> a, Vector256<short> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check256x32u<K>(Vector256<uint> a, Vector256<uint> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check256x32i<K>(Vector256<int> a, Vector256<int> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check256x64u<K>(Vector256<ulong> a, Vector256<ulong> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit Check256x64i<K>(Vector256<long> a, Vector256<long> b, K f)
            where K : unmanaged, IBitLogicKind
                => CheckMatch(a,b,f);

        [MethodImpl(Inline)]
        bit CheckMatch<K,T>(Vector128<T> x, Vector128<T> y, K f = default)
            where K : unmanaged, IBitLogicKind
            where T : unmanaged
        {
            var w = w128;
            var mSvc = gbits.bitlogic<T>();
            var vSvc = VSvc.vbitlogic<T>(w);
            var buffer = Cells.alloc(w);
            ref var dst = ref Cells.first<T>(buffer);
            var cells = gcpu.vcount<T>(w);
            for(byte i=0; i<cells; i++)
                seek(dst, i) = mSvc.eval(vcell(x,i), vcell(y,i), f);
            var v1 = gcpu.vload(w, dst);
            var v2 = vSvc.eval(x,y,f);
            return gcpu.vsame(v2,v1);
        }

        [MethodImpl(Inline)]
        bit CheckMatch<K,T>(Vector256<T> x, Vector256<T> y, K f)
            where K : unmanaged, IBitLogicKind
            where T : unmanaged
        {
            var w = w256;
            var mSvc = gbits.bitlogic<T>();
            var vSvc = VSvc.vbitlogic<T>(w);
            var buffer = Cells.alloc(w);
            ref var dst = ref Cells.first<T>(buffer);
            var cells = gcpu.vcount<T>(w);
            for(byte i=0; i<cells; i++)
                seek(dst, i) = mSvc.eval(vcell(x,i), vcell(y,i), f);
            var v1 = gcpu.vload(w, dst);
            var v2 = vSvc.eval(x,y,f);
            return gcpu.vsame(v2,v1);
        }
    }
}