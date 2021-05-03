//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using W = NumericWidth;

    [ApiHost]
    public readonly struct AsmCore
    {
        public static string[] operands(string instruction)
            => instruction.RightOfFirst(Chars.Space).Split(Chars.Comma).Select(x => x.Trim());

        public static string Format(in AsmSourceLine src)
        {
            if(src.Label.IsNonEmpty)
                return string.Format("{0}:", src.Label.Name);
            else if(src.Statement.IsNonEmpty)
            {
                if(src.Comment.IsNonEmpty)
                    return string.Format("{0,-46} ; {1}", src.Statement, src.Comment.Content);
                else
                    return src.Statement.Format();
            }
            else if(src.Comment.IsNonEmpty)
            {
                return string.Format("; {0}", src.Comment.Content);
            }
            else
                return EmptyString;
        }


        [MethodImpl(Inline), Op]
        public static AsmMnemonic mnemonic(string src)
            => new AsmMnemonic(src);

        [MethodImpl(Inline), Op]
        public static AsmLabel label(Identifier name)
            => new AsmLabel(name);

        [Op]
        public static LocalOffsetVector offsets(W16 w, ReadOnlySpan<AsmRow> src)
        {
            var count = src.Length;
            var buffer = memory.alloc<Address16>(count);
            ref var dst = ref first(buffer);
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i).LocalOffset;
            return buffer;
        }


        [MethodImpl(Inline), Op]
        public static AsmBlockLabel blocklabel(MemoryAddress address)
            => new AsmBlockLabel(string.Format("_{0}", address));

        [MethodImpl(Inline), Op]
        public static AsmStatementExpr statement(string src)
            => new AsmStatementExpr(src.Trim());

        [MethodImpl(Inline), Op]
        public static AsmFormExpr form(AsmOpCodeExpr op, AsmSigExpr sig)
            => new AsmFormExpr(op, sig);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static AsmSigOp sigop<K>(Sym<K> sym)
            where K : unmanaged
                => new AsmSigOp(sym.Name, sym.Expr);

        [MethodImpl(Inline), Op]
        public static AsmExpr expression(string src)
            => new AsmExpr(src);

        [MethodImpl(Inline), Op]
        public static AsmComment comment(string src)
            => new AsmComment(src);

        [MethodImpl(Inline), Op]
        public static AsmOpCodeExpr opcode(string src)
            => new AsmOpCodeExpr(src);

        [MethodImpl(Inline), Op]
        public static AsmSigExpr sig(AsmMnemonic mnemonic, string formatted)
            => new AsmSigExpr(mnemonic,formatted);

        [MethodImpl(Inline), Op]
        public static AsmExprSet pack(AsmOpCodeExpr oc, AsmSigExpr sig, AsmStatementExpr statement)
            => new AsmExprSet(new AsmFormExpr(oc, sig), statement);

        /// <summary>
        /// Defines an IP offset relative to a specified base address, instruction size and target address
        /// </summary>
        /// <param name="base">The base address</param>
        /// <param name="size">The size, in bytes, of the call/branch/jmp instruction</param>
        /// <param name="dst">The call/branch/jmp target</param>
        [MethodImpl(Inline), Op]
        public static MemoryAddress offset(MemoryAddress src, byte fxSize, MemoryAddress dst)
            => (MemoryAddress)(dst - (src + fxSize));

        [MethodImpl(Inline), Op]
        public static MemoryAddress nextip(in AsmCallSite src)
            => nextip(src.Caller.Base, src.LocalOffset, src.InstructionSize);

        [MethodImpl(Inline), Op]
        public static MemoryAddress nextip(MemoryAddress @base, Address16 offset, byte currentsize)
            => @base + offset + currentsize;

        [MethodImpl(Inline), Op, Closures(UInt64k)]
        public static AsmRowSet<T> rowset<T>(T key, AsmRow[] src)
            => new AsmRowSet<T>(key,src);

        [MethodImpl(Inline), Op]
        public static AsmCallSite callsite(AsmCaller caller, Address16 offset, uint4 size)
            => new AsmCallSite(caller, offset, size);

        [MethodImpl(Inline), Op]
        public static AsmCaller caller(MemoryAddress @base, AsmSymbol symbol)
            => new AsmCaller(@base, symbol);

        [MethodImpl(Inline), Op]
        public static AsmCallee callee(MemoryAddress @base, AsmSymbol symbol)
            => new AsmCallee(@base, symbol);

        [MethodImpl(Inline), Op]
        public static AsmCallInfo call(AsmCallSite callsite, AsmCallee target)
            => new AsmCallInfo(callsite, target);

        [MethodImpl(Inline), Op]
        public static CallRel32 call(MemoryAddress client, uint dx)
            => new CallRel32(client, dx);

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(AsmBranchTargetKind kind, MemoryAddress dst, AsmBranchTargetWidth size, Address16 selector)
            => new AsmBranchTarget(dst, kind, size, selector);

        [MethodImpl(Inline), Op]
        public static AsmBranchTarget target(AsmBranchTargetKind kind, MemoryAddress dst, AsmBranchTargetWidth size)
            => new AsmBranchTarget(dst,kind, size);

        [MethodImpl(Inline), Op]
        public static AsmBranchInfo branch(MemoryAddress @base, MemoryAddress ip, byte fxSize, in AsmBranchTarget target)
            => new AsmBranchInfo(@base, ip, target, offset(ip, fxSize, target.Address));

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(byte value, bool direct)
            => new AsmImmInfo(W.W8, value, direct);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(short value, bool direct, Sx sek)
            => new AsmImmInfo(W.W16, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(ushort value, bool direct)
            => new AsmImmInfo(W.W16, value, direct);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(int value, bool direct, Sx sek)
            => new AsmImmInfo(W.W32, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(uint value, bool direct)
            => new AsmImmInfo(W.W32, value, direct);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(long value, bool direct, Sx sek)
            => new AsmImmInfo(W.W64, value, direct, sek);

        [MethodImpl(Inline), Op]
        public static AsmImmInfo imm(ulong value, bool direct)
            => new AsmImmInfo(W.W64, value, direct);
    }
}