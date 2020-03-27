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

    public readonly struct HexDoc
    {        
        [MethodImpl(Inline)]
        public HexDoc(HexLine[] lines)
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
                core.error(e);
                return Option.none<FilePath>();
            }
        }
    }
}