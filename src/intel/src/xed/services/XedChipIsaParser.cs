//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static core;
    using static Root;
    using static XedModels;

    public class XedChipIsaParser : AppService<XedChipIsaParser>
    {
        bool Verbose {get;} = false;

        public Outcome Parse(FS.FilePath src, out ChipMap dst)
        {
            dst = default;

            var chip = ChipCode.None;
            var chips = dict<ChipCode,ChipIsaKinds>();
            using var reader = src.AsciLineReader();
            while(reader.Next(out var line))
            {
                if(line.StartsWith(Chars.Hash))
                    continue;

                var i = line.Index(Chars.Colon);
                if(i != NotFound)
                {
                    if(Verbose)
                        Wf.Row(line);

                    var name = line.Left(i).Trim();
                    if(text.blank(name))
                        continue;

                    if(Enums.parse<ChipCode>(name, out chip))
                    {
                        if(!chips.TryAdd(chip, new ChipIsaKinds(chip)))
                            return (false,string.Format("Duplicate chip code {0}", chip));

                        if(Verbose)
                            Wf.Babble(string.Format("Including {0}", chip));
                    }
                    else
                    {
                        return (false,string.Format("Code for chip {0} not found", name));
                    }
                }
                else
                {
                    var kinds = line.Content.SplitClean(Chars.Tab).Trim().Select(x => Enums.parse<IsaKind>(x,IsaKind.None)).Where(x => x != 0);
                    chips[chip].Add(kinds);
                    if(chips.TryGetValue(chip, out var entry))
                    {
                        entry.Add(kinds);
                        if(Verbose)
                            Wf.Row(string.Format("{0}: {1}", chip, kinds.Delimit(Chars.Comma)));
                    }
                }

            }

            var allChips = ChipCodes().ToArray();
            var buffer = new Index<ChipCode,IsaKinds>(alloc<IsaKinds>(allChips.Length));
            for(var i=0; i<allChips.Length; i++)
            {
                var _code = (ChipCode)i;
                if(chips.TryGetValue(_code, out var entry))
                    buffer[_code] = entry.Kinds;
            }
            dst = new ChipMap(allChips,buffer);
            return true;
        }

        ReadOnlySpan<ChipCode> ChipCodes()
            => Symbols.index<ChipCode>().Kinds;
    }
}
