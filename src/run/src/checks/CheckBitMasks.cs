//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Linq;

    using static Konst;
    using static z;
    using static Checks;

    using static CheckBitMasksStep;

    [ApiHost]
    public ref struct CheckBitMasks
    {
        readonly StringBuilder Log;

        readonly IWfShell Wf;

        uint SuccessCount;

        uint FailureCount;

        public Pair<uint> Counts;

        readonly IPolyrand Random;

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

        public CheckBitMasks(IWfShell wf, IPolyrand random, StringBuilder log)
            : this()
        {
            Wf = wf;
            Log = log;
            SuccessCount = 0;
            FailureCount = 0;
            Counts = default;
            Random = random;
            Init();
            Wf.Created(StepId);
        }

        void Init()
        {
            Cases8 = Random.Fill(z8, (byte)bitsize<byte>(), span<byte>(Reps));
            Cases16 = Random.Fill(z8, (byte)bitsize<ushort>(), span<byte>(Reps));
            Cases32 = Random.Fill(z8, (byte)bitsize<uint>(), span<byte>(Reps));
            Cases64 = Random.Fill(z8, (byte)bitsize<uint>(), span<byte>(Reps));
            Literals8 = Literals.attributed<byte>(base2, typeof(MaskLiterals));
            Literals16 = Literals.attributed<ushort>(base2, typeof(MaskLiterals));
            Literals32 = Literals.attributed<uint>(base2, typeof(MaskLiterals));
            Literals64 = Literals.attributed<ulong>(base2, typeof(MaskLiterals));
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
                return @as<BinaryLiterals<byte>, BinaryLiterals<T>>(Literals8);
            else if(typeof(T) == typeof(ushort))
                return @as<BinaryLiterals<ushort>, BinaryLiterals<T>>(Literals16);
            else if(typeof(T) == typeof(uint))
                return @as<BinaryLiterals<uint>, BinaryLiterals<T>>(Literals32);
            else if(typeof(T) == typeof(ulong))
                return @as<BinaryLiterals<ulong>, BinaryLiterals<T>>(Literals64);
            else
                throw no<T>();
        }

        public void Run()
        {
            Wf.Running(StepId);

            Check(base2);
            CheckLoMask(n0);
            CheckLoMask(n1);
            CheckLoMask(n2);
            Himask(w8);
            Himask(w16);
            Himask(w32);
            Himask(w64);

            Counts = (SuccessCount,FailureCount);
            Wf.Ran(StepId, Counts);

        }

        public void Dispose()
        {
            Wf.Finished(StepId);
        }

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
                var bits = BitSpans.parse(m.Text);
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
                var description = text.format(RenderPatterns.PSx3, title, m.Name, expr);
                Log.AppendLine(description);
            }
        }

        [Op]
        public void CheckLoMask(N0 @case)
        {
            eq((Pow2.pow(3) - 1)^Pow2.pow(3), lo64(3));
            eq((Pow2.pow(7) - 1)^Pow2.pow(7), lo64(7));
            eq((Pow2.pow(13) - 1)^Pow2.pow(13), lo64(13));
            eq((Pow2.pow(25) - 1)^Pow2.pow(25), lo64(25));
            eq((Pow2.pow(59) - 1)^Pow2.pow(59), lo64(59));
        }

        [Op]
        public void CheckLoMask(N1 @case)
        {
            eq(4u, Bits.pop(lo64(3)));
            eq(7u, Bits.pop(lo64(6)));
            eq(13u, Bits.pop(lo64(12)));
            eq(25u, Bits.pop(lo64(24)));
            eq(59u, Bits.pop(lo64(58)));
        }

        [Op]
        public void CheckLoMask(N2 @case)
        {
            var lomask = BitMasks.lo<uint>(6);
            var himask = BitMasks.hi<uint>(8);
            var src = uint.MaxValue;
            var dst = gmath.xor(gmath.xor(src,lomask), himask);
            eq(7u, gbits.ntz(dst));
            eq(8u, (uint)gbits.nlz(dst));
            eq(7u, Bits.pop(BitMasks.lo<uint>(6)));
            eq(12u, Bits.pop(BitMasks.lo<uint>(11)));
        }

        [MethodImpl(Inline)]
        void CheckHiMask<W,T>(W w, T t, Span<CheckHiMaskResult<T>> log)
            where T : unmanaged
            where W : unmanaged, ITypeWidth<W>
        {
            var mincount = (byte)1;
            var maxcount = (byte)bitsize(t);
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
                dst.Lowered = gmath.srl(dst.Mask, (byte)(bitsize(t) -  dst.Count));
                dst.EffectiveWidth = (byte)gbits.effwidth(dst.Lowered);
                dst.Check3 = dst.Count == dst.EffectiveWidth;
            }
        }
    }
}