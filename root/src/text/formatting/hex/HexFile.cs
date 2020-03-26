//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Textual;

    public readonly struct HexFile
    {        
        public static HexFile Read(FilePath src)
        {
            var dst = new List<HexLine>();
            foreach(var line in src.ReadLines())
                HexParser.hexline(line).OnSome(dst.Add);            
            return new HexFile(dst.ToArray());
        }

        [MethodImpl(Inline)]
        HexFile(HexLine[] lines)
        {
            this.Lines = lines;
        }
                
        public HexLine[] Lines {get;}

        public Option<FilePath> Save(FilePath dst)
        {
            try
            {
                using var writer = dst.CreateParentIfMissing().Writer();
                foreach(var line in Lines)                
                    writer.WriteLine(line.Format());
                return dst;
            }
            catch(Exception e)
            {
                term.error(e);
                return Option.none<FilePath>();
            }
        }
    }
}