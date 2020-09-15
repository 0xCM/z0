//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static ExtractTermCode;

    readonly struct CapturedOperation
    {
        public OpIdentity Id {get;}

        public readonly CaptureOutcome Outcome;

        public readonly ParsedEncoding Encoded;

        public byte[] Data
        {
            [MethodImpl(Inline)]
            get => Encoded.Output;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Encoded.Length;
        }

        public ref readonly byte this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Encoded[index];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Encoded.IsNonEmpty;
        }

        [MethodImpl(Inline)]
        public CapturedOperation(OpIdentity id,  CaptureOutcome outcome, ParsedEncoding code)
        {
            Id = id;
            Outcome = outcome;
            Encoded = code;
        }
    }

    [ApiHost]
    public readonly unsafe struct CaptureAlt
    {
        public static X86ApiCapture[] capture(IdentifiedMethod[] src)
            => capture(src, sys.alloc<byte>(Pow2.T14));

        public static X86ApiCapture[] capture(IdentifiedMethod[] src, Span<byte> buffer)
        {
            var count = src.Length;
            var located = sys.alloc<LocatedMethod>(count);
            for(var i=0; i<count; i++)
                located[i] = FunctionDynamic.jit(src[i].Method);

            var captured = sys.alloc<X86ApiCapture>(count);

            for(var i=0; i<count; i++)
            {
                var method = located[i];
                var summary = capture(buffer, method.Id, method.Address);
                var outcome = summary.Outcome;
                captured[i] = DefineMember(method.Id, method.Method, summary.Encoded, outcome.TermCode);
            }
            return captured;
        }

        public static CapturedMember capture(in ApiMember src, Span<byte> buffer)
        {
            var summary = capture(buffer, src.Id, ApiMemberJit.jit(src));
            var size = summary.Data.Length;
            var code = new X86ApiCapture(src.Id, src.Method, summary.Encoded.Input, summary.Encoded.Output, summary.Outcome.TermCode);
            return new CapturedMember(src, code);
        }

        public static X86ApiCapture capture(LocatedMethod located, Span<byte> buffer)
        {
            var summary = capture(buffer, located.Id, located.Address);
            return DefineMember(located.Id, located.Method, summary.Encoded, summary.Outcome.TermCode);
        }

        public static X86ApiCapture capture(IdentifiedMethod src, Span<byte> buffer)
        {
            var located = FunctionDynamic.jit(src.Method);
            var summary = capture(buffer, src.Id, located.Address);
            return DefineMember(located.Id, located.Method, summary.Encoded, summary.Outcome.TermCode);
        }

        public static X86ApiCapture capture(IdentifiedMethod src)
            => capture(src, sys.alloc<byte>(Pow2.T14));

        [MethodImpl(Inline)]
        static X86ApiCapture DefineMember(OpIdentity id, MethodInfo src, Z0.ParsedEncoding bits, ExtractTermCode term)
            => new X86ApiCapture(id, src, bits.Input, bits.Output, term);

        [MethodImpl(Inline)]
        static CapturedOperation capture(Span<byte> buffer, OpIdentity id, MemoryAddress src)
            => capture(buffer, id, src.Pointer<byte>());

        [MethodImpl(Inline), Op]
        static CapturedOperation capture(Span<byte> buffer, OpIdentity id, byte* pSrc)
        {
            var limit = buffer.Length - 1;
            var start = (MemoryAddress)pSrc;
            var offset = 0;
            int? ret_offset = null;
            var end = (MemoryAddress)pSrc;
            var state = default(ExtractState);

            while(offset < limit)
            {
                state = Step(buffer, id, ref offset, ref end, ref pSrc);

                if(ret_offset == null && state.Captured == RET)
                    ret_offset = offset;

                var tc = CalcTerm(buffer, offset, ret_offset, out var delta);
                if(tc != 0)
                    return SummarizeParse(buffer, state, id, tc, start, end, delta);
            }
            return SummarizeParse(buffer, state, id, CTC_BUFFER_OUT, start, end, 0);
        }

        [MethodImpl(Inline)]
        static ExtractState Step(Span<byte> buffer, OpIdentity id, ref int offset, ref MemoryAddress location, ref byte* pSrc)
        {
            var code = Unsafe.Read<byte>(pSrc++);
            buffer[offset++] = code;
            location = pSrc;
            return new ExtractState((uint)offset, location, code);
        }

        [MethodImpl(Inline)]
        static CaptureOutcome Complete(in ExtractState state, ExtractTermCode tc, MemoryAddress start, MemoryAddress end, int delta)
            => new CaptureOutcome(state, (start, (ulong)(end + delta)), tc);

        static CapturedOperation SummarizeParse(Span<byte> buffer, in ExtractState state, OpIdentity id, ExtractTermCode tc, MemoryAddress start, MemoryAddress end, int delta)
        {
            var outcome = Complete(state, tc, start, end, delta);
            var raw = buffer.Slice(0, (int)(end - start)).ToArray();
            var trimmed = buffer.Slice(0, outcome.ByteCount).ToArray();
            var bits = new Z0.ParsedEncoding(start, raw, trimmed);
            return new CapturedOperation(id, outcome, bits);
        }

        [Op]
        static ExtractTermCode CalcTerm(in Span<byte> buffer, int offset, int? ret_offset, out int delta)
        {
            delta = 0;

            if(offset >= 4)
            {
                var tc = Scan4(buffer, offset, out delta);
                if(tc != 0)
                    return tc;
            }

            if(offset >= 5)
            {
                var tc = Scan5(buffer, offset, out delta);
                if(tc != 0)
                    return tc;
            }

            if(offset >= 7 && Zx7(buffer, offset))
            {
                if(ret_offset == null)
                {
                    delta = -6;
                    return CTC_Zx7;
                }
                delta = -(offset - ret_offset.Value);
                return CTC_RET_Zx7;
            }

            return 0;
        }

        const byte ZED = 0;

        const byte RET = 0xc3;

        const byte INTR = 0xcc;

        const byte SBB = 0x19;

        const byte FF = 0xff;

        const byte E0 = 0xe0;

        const byte J48 = 0x48;

        [MethodImpl(Inline), Op]
        static ExtractTermCode Scan4(Span<byte> buffer, int offset, out int delta)
        {
            var result = true;
            delta = -2;

            ref readonly var x0 = ref skip(buffer, offset - 3);
            ref readonly var x1 = ref skip(buffer, offset - 2);
            ref readonly var x2 = ref skip(buffer, offset - 1);
            ref readonly var x3 = ref skip(buffer, offset - 0);

            if(x0 == RET && x1 == SBB)
                return CTC_RET_SBB;
            else if(x0 == RET && x1 == INTR)
                return CTC_RET_INTR;
            else if(x0 == RET && x1 == ZED && x2 == SBB)
                return CTC_RET_ZED_SBB;
            else if(x0 == RET && x1 == ZED && x2 == ZED)
                return CTC_RET_Zx3;
            else if(x0 == INTR && x1 == INTR)
                return CTC_INTRx2;
            else
                return 0;

        }

        [MethodImpl(Inline), Op]
        static ExtractTermCode Scan5(Span<byte> buffer, int offset, out int delta)
        {
            var result = true;
            delta = 0;

            result = result &= match(buffer, offset - 5, ZED);
            result = result &= match(buffer, offset - 4, ZED);
            result = result &= match(buffer, offset - 3, J48);
            result = result &= match(buffer, offset - 2, FF);
            result = result &= match(buffer, offset - 1, E0);

            return result ? CTC_JMP_RAX : default;
        }

        [MethodImpl(Inline), Op]
        static bool match(ReadOnlySpan<byte> src, int index, byte test)
            => skip(src,index) == test;

        [MethodImpl(Inline), Op]
        static bool Zx7(ReadOnlySpan<byte> buffer, int offset)
        {
            var result = true;
            ref readonly var x = ref first(buffer);
            result &= regress(x,0) == ZED;
            result &= regress(x,1) == ZED;
            result &= regress(x,2) == ZED;
            result &= regress(x,3) == ZED;
            result &= regress(x,4) == ZED;
            result &= regress(x,5) == ZED;
            result &= regress(x,6) == ZED;
            return result;
        }
    }
}