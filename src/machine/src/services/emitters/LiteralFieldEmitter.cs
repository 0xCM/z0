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
                var fields = LiteralFields.stringrefs(part.types);
                if(fields.Length != 0)
                {
                    var datapath = EmissionRoot + FileName.Define(part.Id.Format(), FileExtensions.Csv);
                    LiteralFields.emit(fields, datapath);

                    var codepath = datapath.ChangeExtension(FileExtensions.Cs);
                 
                }
            }
        }
    }
}