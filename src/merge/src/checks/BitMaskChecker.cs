//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static Checks;
    using static z;
    using static BitMasks;

    [ApiHost]
    public ref struct BitMaskChecker
    {
        readonly StringBuilder Log;

        readonly IWfShell Wf;

        readonly WfHost Host;

        uint SuccessCount;

        uint FailureCount;

        public Pair<uint> Counts;

        readonly IPolyStream DataSource;

        Span<byte> Cases8;

        Span<byte> Cases16;

        Span<byte> Cases32;

        Span<byte> Cases64;

        BinaryLiterals<byte> Literals8;

        BinaryLiterals<ushort> Literals16;

        BinaryLiterals<uint> Literals32;

        BinaryLiterals<ulong> Literals64;

        CheckHiMaskResults<byte> HiMaskResults8;

        CheckHiMaskResults<ushort> HiMaskResults16;

        CheckHiMaskResults<uint> HiMaskResults32;

        CheckHiMaskResults<ulong> HiMaskResults64;

        public BitMaskChecker(IWfShell wf, WfHost host, IPolyStream source, StringBuilder log)
            : this()
        {
            Host = host;
            Wf = wf.WithHost(host);
            Log = log;
            SuccessCount = 0;
            FailureCount = 0;
            Counts = default;
            DataSource = source;
            Init();
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        [Op]
        void Init()
        {
            Cases8 = DataSource.Fill(z8, (byte)bitwidth<byte>(), span<byte>(Reps));
            Cases16 = DataSource.Fill(z8, (byte)bitwidth<ushort>(), span<byte>(Reps));
            Cases32 = DataSource.Fill(z8, (byte)bitwidth<uint>(), span<byte>(Reps));
            Cases64 = DataSource.Fill(z8, (byte)bitwidth<uint>(), span<byte>(Reps));
            Literals8 = Literals.tagged<byte>(base2, typeof(BitMasks.Literals));
            Literals16 = Literals.tagged<ushort>(base2, typeof(BitMasks.Literals));
            Literals32 = Literals.tagged<uint>(base2, typeof(BitMasks.Literals));
            Literals64 = Literals.tagged<ulong>(base2, typeof(BitMasks.Literals));
            HiMaskResults8 = alloc<CheckHiMaskResult<byte>>(Reps);
            HiMaskResults16 = alloc<CheckHiMaskResult<ushort>>(Reps);
            HiMaskResults32 = alloc<CheckHiMaskResult<uint>>(Reps);
            HiMaskResults64 = alloc<CheckHiMaskResult<ulong>>(Reps);
        }

        [MethodImpl(Inline)]
        ReadOnlySpan<byte> Cases<W>(W w = default)
            where W : unmanaged, ITypeWidth<W>
        {
            if(typeof(W) == typeof(W8))
                return Cases8;
            else if(typeof(W) == typeof(W16))
                return Cases16;
            else if(typeof(W) == typeof(W32))
                return Cases32;
            else if(typeof(W) == typeof(W64))
                return Cases16;
            else
                throw no<W>();
        }

        [MethodImpl(Inline)]
        BinaryLiterals<T> Lit<T>(T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return z.@as<BinaryLiterals<byte>, BinaryLiterals<T>>(Literals8);
            else if(typeof(T) == typeof(ushort))
                return z.@as<BinaryLiterals<ushort>, BinaryLiterals<T>>(Literals16);
            else if(typeof(T) == typeof(uint))
                return z.@as<BinaryLiterals<uint>, BinaryLiterals<T>>(Literals32);
            else if(typeof(T) == typeof(ulong))
                return z.@as<BinaryLiterals<ulong>, BinaryLiterals<T>>(Literals64);
            else
                throw no<T>();
        }

        [Op]
        public void Run()
        {
            var flow = Wf.Running();
            var results = 0ul;
            var index = z8;
            Check(base2);
            CheckLoMasks(ref index, ref results);
            Himask(w8);
            Himask(w16);
            Himask(w32);
            Himask(w64);
            Counts = (SuccessCount,FailureCount);
            Wf.Ran(flow, Counts);
        }

        [Op]
        public static void CheckLoMasks(ref byte index, ref ulong log)
        {
            CheckLoMask(n0, ref index, ref log);
            CheckLoMask(n1, ref index, ref log);
            CheckLoMask(n2, ref index, ref log);
        }

        [MethodImpl(Inline), Op]
        public static void CheckLoMask(N0 @case, ref byte index, ref ulong log)
        {
            eq((Pow2.pow(3) - 1)^Pow2.pow(3), lo64(3), ref index, ref log);
            eq((Pow2.pow(7) - 1)^Pow2.pow(7), lo64(7), ref index, ref log);
            eq((Pow2.pow(13) - 1)^Pow2.pow(13), lo64(13), ref index, ref log);
            eq((Pow2.pow(25) - 1)^Pow2.pow(25), lo64(25), ref index, ref log);
            eq((Pow2.pow(59) - 1)^Pow2.pow(59), lo64(59), ref index, ref log);
        }

        [MethodImpl(Inline), Op]
        public static void CheckLoMask(N1 @case, ref byte index, ref ulong log)
        {
            eq(4u, Bits.pop(lo64(3)), ref index, ref log);
            eq(7u, Bits.pop(lo64(6)), ref index, ref log);
            eq(13u, Bits.pop(lo64(12)), ref index, ref log);
            eq(25u, Bits.pop(lo64(24)), ref index, ref log);
            eq(59u, Bits.pop(lo64(58)), ref index, ref log);
        }

        [MethodImpl(Inline), Op]
        public static void CheckLoMask(N2 @case, ref byte index, ref ulong log)
        {
            var lomask = BitMasks.lo<uint>(6);
            var himask = BitMasks.hi<uint>(8);
            var src = uint.MaxValue;
            var dst = gmath.xor(gmath.xor(src,lomask), himask);
            eq(7u, gbits.ntz(dst), ref index, ref log);
            eq(8u, (uint)gbits.nlz(dst), ref index, ref log);
            eq(7u, Bits.pop(BitMasks.lo<uint>(6)), ref index, ref log);
            eq(12u, Bits.pop(BitMasks.lo<uint>(11)), ref index, ref log);
        }

        [Op]
        void Check(Base2 @base)
        {
            Check(@base, w8);
            Check(@base, w16);
            Check(@base, w32);
            Check(@base, w64);
        }

        [Op]
        void Check(Base2 @base, W8 w)
        {
            Check(@base, z8);
        }

        [Op]
        void Check(Base2 @base, W16 w)
            => Check(@base, z16);

        [Op]
        void Check(Base2 @base, W32 w)
            => Check(@base, z32);

        [Op]
        void Check(Base2 @base, W64 w)
            => Check(@base, z64);

        [Op]
        public void Himask(W8 w)
            => CheckHiMask(w, z8, HiMaskResults8);

        [Op]
        public void Himask(W16 w)
            => CheckHiMask(w, z16, HiMaskResults16);

        [Op]
        public void Himask(W32 w)
            => CheckHiMask(w, z32, HiMaskResults32);

        [Op]
        public void Himask(W64 w)
            => CheckHiMask(w,z64, HiMaskResults64);

        [MethodImpl(Inline)]
        void Check<T>(Base2 @base, T t = default)
            where T : unmanaged
        {
            var literals = Lit<T>();
            foreach(var m in literals.Storage)
            {
                var bits = BitSpans.parse32(m.Text);
                var bitval = bits.Convert<T>();
                var ok = gmath.eq(bitval,m.Data);

                if(ok)
                    SuccessCount++;
                else
                    FailureCount++;

                var sym = ok ? "==" : "!=";
                var title = ok ? "Success" : "Failure";
                var normalized = BitString.normalize(m.Text);
                var bs = BitString.scalar(m.Data);
                var expr = text.format("{0} {1} {2}", normalized, sym, bs);
                var description = text.format(RP.PSx3, title, m.Name, expr);
                Log.AppendLine(description);
            }
        }

        [MethodImpl(Inline)]
        void CheckHiMask<W,T>(W w, T t, Span<CheckHiMaskResult<T>> log)
            where T : unmanaged
            where W : unmanaged, ITypeWidth<W>
        {
            var mincount = (byte)1;
            var maxcount = (byte)bitwidth(t);
            var cases = Cases(w);

            for(var i=0u; i<Reps; i++)
            {
                ref var dst = ref seek(log,i);
                dst.Check1 = true;
                dst.Count = skip(cases, i);
                dst.Mask = BitMasks.hi(dst.Count,t);
                dst.PopCount = (byte)gbits.pop(dst.Mask);
                dst.Check1 = dst.PopCount  != dst.Count;
                dst.Check1 = eq(dst.Count, gbits.pop(dst.Mask));
                dst.Lowered = gmath.srl(dst.Mask, (byte)(bitwidth(t) -  dst.Count));
                dst.EffectiveWidth = (byte)gbits.effwidth(dst.Lowered);
                dst.Check3 = dst.Count == dst.EffectiveWidth;
            }
        }
    }
}