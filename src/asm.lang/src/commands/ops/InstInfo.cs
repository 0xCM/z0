//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using Windows;

    using static Root;
    using static core;
    using static IntelSdm;

    partial class AsmCmdService
    {
        [CmdOp(".symtypes")]
        Outcome SymbolTypes(CmdArgs args)
        {
            var result = Outcome.Success;
            var src = SymTypes.View;
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var t = ref skip(src,i);
                Row(t.Name);
            }

            return result;
        }


        [CmdOp(".hexcheck")]
        public Outcome CheckMemoryLookup(CmdArgs args)
        {
            var capacity = Pow2.T16;
            var blocks = Wf.ApiHex().ReadBlocks().View;
            var count = blocks.Length;

            if(count > capacity)
                return (false, "Insufficient cpacity");

            var distinct = blocks.Map(b => b.BaseAddress).ToArray().ToHashSet();
            if(distinct.Count != count)
                Warn(string.Format("There should be {0} distinct base addresses and yet there are {1}", count, distinct.Count));

            var symbols = MemorySymbols.alloc(capacity);

            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                symbols.Deposit(block.BaseAddress, block.Size, block.OpUri.Format());
            }

            Status("Creating lookup");

            var lookup = symbols.ToLookup();
            var entries = slice(lookup.Symbols, 0,symbols.EntryCount);
            var dst = Db.AppLog("addresses.lookup", FS.Csv);
            var emitting = Wf.EmittingTable<MemorySymbol>(dst);
            var emitted = Tables.emit(entries, dst);
            Wf.EmittedTable(emitting,emitted);
            var found = 0;

            var hashes = entries.Map(x => x.HashCode).ToArray().ToHashSet();
            if(hashes.Count != count)
            {
                Warn(string.Format("There should be {0} distinct hash codes and yet there are {1}", count, hashes.Count));
            }

            for(var i=0; i<count; i++)
            {
                ref readonly var block = ref skip(blocks,i);
                if(lookup.FindIndex(block.BaseAddress, out var index))
                    found++;
            }

            Wf.Status(string.Format("Blocks: {0}", count));
            Wf.Status(string.Format("Found: {0}", found));
            return true;
        }


        [CmdOp(".inst-info")]
        Outcome ShowInstInfo(CmdArgs args)
        {
            const string TitleMarker = "# ";
            const string TableMarker = "## ";
            const string Separator = "------";
            const string TableTileFormat = "# {0}";
            const string InstTitleFormat = "# Instruction {0}";
            const string Rejoin = " | ";
            const char ColSep = Chars.Pipe;

            var result = Outcome.Success;
            var foundtable = false;
            var parsingrows = false;
            var tablekind = TableKind.None;
            var rowcount = 0;
            if(args.Length < 1)
                return (false, "Argument not supplied");

            var id = args[0].Value;
            var src = Workspace.InstInfo(id);
            if(!src.Exists)
                return (false, FS.missing(src));

            var info = default(InstructionInfo);
            var cols = Index<TableColumn>.Empty;
            var rows = list<TableRow>();
            var rowidx = z16;
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                if((line.IsEmpty || line.StartsWith(Separator)) && !parsingrows)
                    continue;

                if(parsingrows && line.IsEmpty)
                {
                    foundtable = false;
                    parsingrows = false;
                    rowcount = 0;
                    continue;
                }

                var content = line.Content;
                if(parsingrows)
                {
                    var values  = content.SplitClean(ColSep);
                    var valcount = values.Length;

                    if(valcount != cols.Count)
                        Warn($"{valcount} != {cols.Count}");

                    if(valcount != 0)
                    {
                        Row(values.Join(Rejoin));
                        rowcount++;
                    }
                    continue;
                }

                if(foundtable && !parsingrows)
                {
                    var header = content.SplitClean(ColSep);
                    if(header.Length == 0)
                    {
                        Warn(string.Format("Expected header"));
                    }
                    else
                    {
                        cols = IntelSdm.columns(header);
                        var formatted = cols.Select(c => c.Format()).Join(Rejoin);
                        Row(formatted);
                        parsingrows = true;
                    }
                }

                if(content.StartsWith(TitleMarker))
                {
                    info = InstructionInfo.init(content.Remove(TitleMarker));
                    Row(string.Format(InstTitleFormat, info.Mnemonic.Format(MnemonicCase.Uppercase)));
                }
                else if(content.StartsWith(TableMarker))
                {
                    tablekind = TableKinds.from(content.Remove(TableMarker).Trim());
                    Row(Chars.Space);
                    Row(string.Format(TableTileFormat, tablekind));
                    Row(RP.PageBreak120);
                    foundtable = true;
                }
            }

            return result;
        }
    }
}