//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static Konst;
    using static Root;

    public readonly struct G
    {
        public static G Service => default(G);

        void GenerateMasks()
        {
            var literals = BitMask.NumericLiterals;
            for(var i=0; i < literals.Length; i++)
            {
                ref readonly var literal = ref skip(literals,i);
                var x = $"{literal.Name} = {literal.Text}";
                term.print(x);
            }
        }
        
        void GenerateDocs()
        {   
            var docs = Commented.collect();
            term.print($"Collected documentation for {docs.Count} parts");
        }
        
        public void Generate()
        {            
            GenerateDocs();
            //EnumGenerator.Service.Generate();
        }
    }
}