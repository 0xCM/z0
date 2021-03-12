//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines a file name along with the extension in isolation
    /// and without ascribing additional path content
    /// </summary>
    public class FileName : PathComponent<FileName>
    {
        [MethodImpl(Inline)]
        public static FileName define(string name)
            => new FileName(name);

        public FileName()
        {

        }

        public FileName(string name)
            : base(name)
            {

            }

        public FileName(string name, string ext)
            : base($"{name}.{ext}")
            {

            }

        [MethodImpl(Inline)]
        public static FileName operator + (FileName name, FileExtension ext)
            => FileName.define($"{name.Name}.{ext.Name}");

        /// <summary>
        /// Determines whether the filename, begins with a specified substring
        /// </summary>
        /// <param name="substring">The substring to match</param>
        [MethodImpl(Inline)]
        public bool StartsWith(string substring)
            => Name.StartsWith(substring, NoCase);

        /// <summary>
        /// Dtermines whether the name of a file is of the form {owner}.{.}.{*}
        /// </summary>
        /// <param name="owner">The owner to test</param>
        public bool OwnedBy(PartId owner)
            => StartsWith(owner.ToString().ToLower() + Chars.Dot);

        /// <summary>
        /// Determines whether the name of a file is of the form {owner}.{host}.{*}
        /// </summary>
        /// <param name="host">The owner to test</param>
        public bool HostedBy(ApiHostUri host)
            => StartsWith(string.Concat(host.Owner.Format(), Chars.Dot, host.Name.ToLower(), Chars.Dot));

    }
}