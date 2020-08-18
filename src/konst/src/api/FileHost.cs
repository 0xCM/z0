//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Determines the api host that owns the file, if any
        /// </summary>
        /// <param name="src">The source file</param>
        public static Option<ApiHostUri> FileHost(this FileName src)
        {
            var components = src.WithoutExtension.Name.Split(Chars.Dot);
            if(components.Length == 2)
            {
                var owner = Z0.Enums.Parse(components[0], PartId.None);
                if(owner.IsSome())
                    return z.some(ApiHostUri.Define(owner, components[1]));
            }
            return z.none<ApiHostUri>();
        }

        /// <summary>
        /// Determines the api host that owns the file, if any
        /// </summary>
        /// <param name="src">The source file</param>
        [MethodImpl(Inline)]
        public static Option<ApiHostUri> FileHost(this FilePath src)
            => src.FileName.FileHost();
    }
}