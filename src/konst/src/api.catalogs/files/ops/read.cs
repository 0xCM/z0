//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;
    using static z;

    partial struct ApiFiles
    {
        [MethodImpl(Inline)]
        public static IApiHexReader hexreader<H>(H rep = default)
            where H : struct, IArchiveReader
        {
            if(typeof(H) == typeof(ApiHexReader))
                return new ApiHexReader();
            else
                throw no<H>();
        }

        /// <summary>
        /// Enumerates the content of all archived files
        /// </summary>
        public static IEnumerable<ApiCodeBlock> read(ApiCodeArchive src)
        {
            var list = src.List();
            var iCount = list.Count;
            for(var i=0; i<iCount; i++)
            {
                var path = list[i].Path;
                var items = ApiArchives.hexblocks(path);
                var jCount = items.Length;
                for(var j=0; j<jCount; j++)
                    yield return items[j];            }
        }

        /// <summary>
        /// Enumerates the content of archived files owned by a specified part
        /// </summary>
        public static IEnumerable<ApiCodeBlock> read(ApiCodeArchive src, PartId owner)
        {
            foreach(var file in src.Files(owner))
            foreach(var item in src.Read(file))
                if(item.IsNonEmpty)
                    yield return item;
        }
    }
}