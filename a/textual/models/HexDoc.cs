//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    public readonly struct HexDoc
    {        
        [MethodImpl(Inline)]
        public HexDoc(OpExtractSegment[] lines)
        {
            this.Lines = lines;
        }
                
        public OpExtractSegment[] Lines {get;}

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
                error(e);
                return none<FilePath>();
            }
        }
    }
}