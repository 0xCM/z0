//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    using static Root;

    public readonly struct FieldCapture
    {
        public static FieldCapture Service => default;

        public FieldRef[] StringLiterals(params Type[] types)
        {
            var references = list<FieldRef>();
            for(var i=0; i<types.Length; i++)
            {
                var fields = types[i].DeclaredFields().Literals().Where(f => f.FieldType == typeof(string)).ToArray();
                for(var j=0; j<fields.Length; j++)
                {
                    var field = fields[j];
                    var value = field.GetRawConstantValue() as string;
                    var data = span(value);
                    var address = MemoryAddress.From(head(data)); 
                    var memref =  new MemRef(address, value.Length*2);              
                    references.Add((field, memref));
                }
            }
            return references.ToArray();
        }

        public FieldValues<T> NumericLiterals<T>(params Type[] types)
            where T : unmanaged
        {
            var literals = list<FieldValue<T>>();

            for(var i=0; i<types.Length; i++)
            {
                var values = types[i].LiteralFieldValues<T>().ToSpan();
                for(var j=0; j<values.Length; j++)
                    literals.Add(skip(values,j));
            }
            return literals.ToArray();
        }

        public void Emit(ReadOnlySpan<FieldRef> src, FilePath dst)
        {            
            using var literals = dst.Writer();
            literals.WriteLine(text.concat("Addresss".PadRight(16),  " | ", "LiteralValue"));
            for(var i=0; i<src.Length; i++)
            {
                ref readonly var field = ref skip(src,i);
                var memref = field.Location;
                var address = memref.Address;
                var data = memref.Load();
                var chars = span16c(data);
                var cstr = chars.ToString();      
                literals.WriteLine(text.concat(address.Format().PadRight(16), " | ", cstr));
            }
        }
    }
}