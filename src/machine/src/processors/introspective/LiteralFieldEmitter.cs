//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    public readonly struct LiteralFieldEmitter
    {
        readonly IAppContext Context;

        public LiteralFieldEmitter(IAppContext context)
        {
            Context = context;
        }

        FolderPath EmissionRoot
            => Context.AppPaths.AppDataRoot + FolderName.Define("literals");
    
        public void Emit()
        {
            EmissionRoot.Clear();
            
            var src = KnownParts.Service.Known;
            var parts = from part in  KnownParts.Service.Known
                        let types = part.Owner.Types()
                        orderby part.Id
                        select (part.Id, types);

            foreach(var part in parts)
            {
                var segments = LiteralFieldRefs.strings(part.types);
                if(segments.Length != 0)
                    FieldCapture.emit(segments, EmissionRoot + FileName.Define(part.Id.Format(), FileExtensions.Csv));
            }
        }
    }
}