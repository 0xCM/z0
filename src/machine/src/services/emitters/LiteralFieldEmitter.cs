//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Linq;

    using static z;

    public readonly struct LiteralFieldEmitter
    {
        readonly IAppContext Context;

        public LiteralFieldEmitter(IAppContext context)
        {
            Context = context;
        }


        static void emit(FieldRef[] fields, FilePath path)
        {            
            const string Sep = "| ";

            var src = span(fields);            
            var dst = list<string>();
            using var writer = path.Writer();
            
            for(var i=0u; i<src.Length; i++)
            {
                if(i == 0)
                {
                    var header = text.concat(
                            "Field Addresss".PadRight(16), Sep,
                            "Field Width".PadRight(16), Sep,
                            "Declaring Type".PadRight(36), Sep, 
                            "Field Name".PadRight(36), Sep, 
                            "Value".PadRight(48), Sep);
                    writer.WriteLine(header);

                }
                try
                {
                    ref readonly var field = ref skip(src,i);
                    var datatype = field.KindId;
                    if(datatype == PrimalKindId.String || datatype == PrimalKindId.C16)
                        continue;

                    var declarer = field.Metadata.DeclaringType;                
                    var data = field.Reference.Load();
                    var content = LiteralFields.format(field);

                    var dtName = declarer.IsEnum 
                        ? text.concat(declarer.Name, Chars.Colon, datatype.Format()) 
                        : datatype.Format();


                    var line = text.concat(
                        field.Address.Format().PadRight(16), Sep, 
                        field.Width.Count.ToString().PadRight(16), Sep,
                        declarer.Name.PadRight(36), Sep, 
                        field.Metadata.Name.PadRight(36), Sep,
                        content.PadRight(48), Sep
                        );
                    
                    writer.WriteLine(line);
                }
                catch(Exception e)
                {
                    term.error(e);
                }
            }        
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
                var fields = LiteralFields.refs(part.types);
                if(fields.Length != 0)
                {
                    var datapath = EmissionRoot + FileName.Define(part.Id.Format(), FileExtensions.Csv);
                    emit(fields, datapath);                                     
                }
            }
        }
    }
}