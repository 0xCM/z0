//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Konst;
    using static core;

    partial struct LiteralFields
    {
        public static void emit(FieldRef[] fields, FilePath path)
        {            
            const string Sep = "| ";

            var src = span(fields);            
            var dst = list<string>();
            
            for(var i=0u; i<src.Length; i++)
            {
                ref readonly var field = ref skip(src,i);
                var datatype = field.KindId;
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
                
                dst.Add(line);                
            }
        
            if(dst.Count != 0)
            {
                using var writer = path.Writer();
                var header = text.concat(
                        "Field Addresss".PadRight(16), Sep,
                        "Field Width".PadRight(16), Sep,
                        "Declaring Type".PadRight(36), Sep, 
                        "Field Name".PadRight(36), Sep, 
                        "Value".PadRight(48), Sep);
                writer.WriteLine(header);
                iter(dst,line => writer.WriteLine(line));
            }
        }
    }
}