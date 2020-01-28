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
    using System.Reflection;
    using System.IO;

    using static zfunc;
 
    public static class DataResourceReport
    {
        public static DataResourceIndex Save(DataResourceIndex resources, FilePath dst)
        {            
            dst.FolderPath.CreateIfMissing();
            var delimter = spaced(pipe());
            var header = concat(
                "Offset".PadRight(8), delimter,
                "Location".PadRight(16), delimter,  
                "Length".PadRight(10), delimter, 
                "Id") ;

            var start = 0ul;
            using var writer = new StreamWriter(dst.Name, false);  
            writer.WriteLine(header);         
            foreach(var r in resources.Indexed.OrderBy(x => x.Location))
            {
                if(start == 0)
                    start = r.Location;
                    
                var offset = r.Location - start;
                
                var description = concat(
                        offset.FormatAsmHex(4).PadRight(8), delimter,
                        r.Location.FormatAsmHex().PadRight(16), delimter, 
                        r.Length.FormatAsmHex(4).PadRight(10), delimter, 
                        r.Id);
                writer.WriteLine(description);
            }
            return resources;
        }
    }
}