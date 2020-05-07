//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    /// <summary>
    /// Defines filename facilites common to all archives
    /// </summary>
    public interface IArchiveFileNames : IArchiveExtensions
    {
        [MethodImpl(Inline)]
        FileName LegalFileName(OpIdentity id, FileExtension ext)
            => id.ToLegalFileName(ext);

        [MethodImpl(Inline)]
        FileName LegalFileName(PartId part, OpIdentity id, FileExtension ext)
            => FileName.Define(text.concat(part.Format(), Chars.Dot, LegalFileName(id,ext)));

        [MethodImpl(Inline)]
        FileName LegalFileName(ApiHostUri host, OpIdentity id, FileExtension ext)
            => FileName.Define(text.concat(host.Owner.Format(), Chars.Dot, host.Name, Chars.Dot, LegalFileName(id,ext)));

        [MethodImpl(Inline)]
        FileName LegalFileName(ApiHostUri host, FileExtension ext)
            => FileName.Define(text.concat(host.Owner.Format(), text.dot(), host.Name), ext);

        FileName AsmFileName(OpIdentity id) 
            => LegalFileName(id, Asm);

        FileName AsmFileName(ApiHostUri host)
            => LegalFileName(host, Asm);

        FileName HexFileName(OpIdentity id) 
            => LegalFileName(id, Hex);       
    }
}