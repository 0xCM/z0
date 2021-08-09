//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using static core;

    partial class AsmCmdService
    {
        [CmdOp(".load-host-asm")]
        Outcome LoadApiAsm(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = AsmLoader.LoadHostStatements(ApiArchive.StatementTables()).Sort(new HostAsmComparer()).View;
            var count = src.Length;
            var buffer = alloc<AsmDataBlock>(count);
            ref var dst = ref first(buffer);
            for(var i=0u; i<count; i++)
            {
                ref var b = ref seek(dst,i);
                ref readonly var s = ref skip(src,i);
                b.GlobalIndex = i;
                b.BlockAddress = s.BlockAddress;
                b.IP = s.IP;
                b.BlockOffset = s.BlockOffset;
                text.asci(s.Expression.Content, b.Expression.Bytes);
            }

            return result;
        }

        [CmdOp(".gen-token-specs")]
        Outcome GenTokenSpecs(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = Z0.Tokens.concat(Symbols.index<AsmOpCodeTokens.ModRmToken>());
            var dst = Db.AppLog("tokens", FS.List);
            Emit(src,dst);
            return result;
        }

        public void Emit(ReadOnlySpan<AsciCode> src, FS.FilePath dst)
        {
            var emitting = EmittingFile(dst);
            using var writer = dst.AsciWriter();
            var i=0;
            var lines = 0u;
            var count = src.Length;
            while(i++<count)
            {
                ref readonly var c = ref skip(src,i);
                if(c == AsciCode.Null)
                {
                    writer.WriteLine();
                    lines++;
                }
                else
                    writer.Write((char)c);
            }
            EmittedFile(emitting, lines);
        }

    }

    readonly struct HostAsmComparer : IComparer<AsmHostStatement>
    {
        public int Compare(AsmHostStatement x, AsmHostStatement y)
            => x.IP.CompareTo(y.IP);
    }
}