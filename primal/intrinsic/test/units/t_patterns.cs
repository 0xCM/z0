//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static nfunc;

    public class t_patterns : IntrinsicTest<t_patterns>
    {

        void lanemerge256_datagen()
        {
            Trace(Vec256PatternData.DefineLaneMergeData8u().Format());
            Trace(Vec256PatternData.DefineLaneMergeData16u().FormatHex(sep: AsciSym.Comma, specifier:true));

        }
        
        void clearalt_datagen()
        {
            var name = "ClearAlt256x";
            Trace(Vec256PatternData.DefineClearAlt<byte>().FormatProperty(name));
            Trace(Vec256PatternData.DefineClearAlt<ushort>().FormatProperty(name));

        }

        public void byte_kind()
        {
            var def = sbuild();
            var indent = new string(AsciSym.Space,4);
            var indent2 = indent + indent;
            def.AppendLine($"{indent}public enum ByteKind : byte");
            def.AppendLine($"{indent}{AsciSym.LBrace}");
            for(var i=0; i<256; i++)
            {
                var label = "X" + ((byte)i).FormatHex(zpad:true, specifier: false, prespec:false, uppercase:true);
                var value = ((byte)i).FormatHex();
                var entry = $"{indent2}{label} = {value},";
                def.AppendLine(entry);

            }

            def.AppendLine($"{indent}{AsciSym.RBrace}");
            Trace(def.ToString());
        }

 
    }


}