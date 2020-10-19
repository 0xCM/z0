//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a file name along with the extension in isolation
    /// and without ascribing additional path content
    /// </summary>
    public class FileName : PathComponent<FileName>
    {
        [MethodImpl(Inline)]
        public static FileName define(PartId owner, string hostname, FileExtension ext)
            => define(text.concat(owner.Format(), Chars.Dot, hostname), ext);

        [MethodImpl(Inline)]
        public static FileName define(string name)
            => new FileName(name);

        [MethodImpl(Inline)]
        public static FileName define(string name, string ext)
            => new FileName(name,ext);

        [MethodImpl(Inline)]
        public static FileName define(string name, FileExtension ext)
            => new FileName(name, ext.Name);

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
        public FileName(string name, FileExtension ext)
            : this(name, ext.Name)
        {

        }

        /// <summary>
        /// Does the file have an extension?
        /// </summary>
        public bool HasExtension
            => Path.HasExtension(Name);

        /// <summary>
        /// The name of the file sans extension
        /// </summary>
        public FileName WithoutExtension
            => FileName.define(Path.GetFileNameWithoutExtension(Name));

        /// <summary>
        /// The file's extension, if any
        /// </summary>
        public FileExtension Ext
            => HasExtension
            ? FileExtension.Define(Path.GetExtension(Name))
            : FileExtension.Empty;

        /// <summary>
        /// Renames the file (in the model, not on disk)
        /// </summary>
        /// <param name="name">The new file name</param>
        [MethodImpl(Inline)]
        public FileName WithNewName(string name)
            => Path.HasExtension(name)
            ? FileName.define(name)
            : FileName.define(name, Ext.Name);

        [MethodImpl(Inline)]
        public static FileName operator + (FileName name, FileExtension ext)
            => FileName.define($"{name.Name}.{ext.Name}");

        /// <summary>
        /// Determines whether the filename, including the extension, contains a specified substring
        /// </summary>
        /// <param name="substring">The substring to match</param>
        [MethodImpl(Inline)]
        public bool Contains(string substring)
            => Name.Contains(substring, NoCase);

        /// <summary>
        /// Determines whether the filename, including the extension, ends with a specified substring
        /// </summary>
        /// <param name="substring">The substring to match</param>
        [MethodImpl(Inline)]
        public bool EndsWith(string substring)
            => Name.EndsWith(substring, NoCase);

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
        /// Specifies the file's owning part, if any
        /// </summary>
        public PartId Owner
            => ApiPartIdParser.single(WithoutExtension.Name.Remove("z0."));

        /// <summary>
        /// Determines whether the name of a file is of the form {owner}.{host}.{*}
        /// </summary>
        /// <param name="host">The owner to test</param>
        public bool HostedBy(ApiHostUri host)
            => StartsWith(string.Concat(host.Owner.Format(), Chars.Dot, host.Name.ToLower(), Chars.Dot));

        [MethodImpl(Inline)]
        public FileName ChangeExtension(FileExtension ext)
            => define(Path.GetFileNameWithoutExtension(Name), ext);
    }
}