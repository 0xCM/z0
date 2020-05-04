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

    partial class XTend
    {
        /// <summary>
        /// Determines the api host that owns the file, if any
        /// </summary>
        /// <param name="src">The source file</param>
        public static ApiHostUri FileHost(this FileName src)
        {
            var components = src.WithoutExtension.Name.Split(Chars.Dot);
            if(components.Length == 2)
            {
                var owner = Enums.parse(components[0], PartId.None);
                if(owner.IsSome())
                    return ApiHostUri.Define(owner, components[1]);
            }
            return ApiHostUri.Empty;
        }

        /// <summary>
        /// Determines the api host that owns the file, if any
        /// </summary>
        /// <param name="src">The source file</param>
        [MethodImpl(Inline)]
        public static ApiHostUri FileHost(this FilePath src)
            => src.FileName.FileHost();
        
    }
}