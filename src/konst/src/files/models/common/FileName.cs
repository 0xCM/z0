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

    /// <summary>
    /// Defines a file name along with the extension in isolation 
    /// and without ascribing additional path content
    /// </summary>
    public class FileName : PathComponent<FileName>
    {                
        public static bool IsSome(FileName src)
            => !string.IsNullOrEmpty(src?.Name);
        
        [MethodImpl(Inline)]
        public static FileName Define(string name)
            => new FileName(name);

        [MethodImpl(Inline)]
        public static FileName Define(string name, string ext)
            => new FileName(name,ext);

        [MethodImpl(Inline)]
        public static FileName Define(string name, FileExtension ext)
            => new FileName(name, ext.Name);

        /// <summary>
        /// Does the file have an extension?
        /// </summary>
        public bool HasExtension 
            => Path.HasExtension(Name);

        /// <summary>
        /// The name of the file sans extension
        /// </summary>
        public FileName WithoutExtension 
            => FileName.Define(Path.GetFileNameWithoutExtension(Name));

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
        /// <param name="newName">The new file name</param>
        [MethodImpl(Inline)]
        public FileName WithNewName(string newName)
            => Path.HasExtension(newName) ? FileName.Define(newName) : FileName.Define(newName, Ext.Name);

        public static FileName Timestamped(FileName src)
        {
            var first = new DateTime(2019,1,1);
            var current = DateTime.Now;
            var elapsed = (long) (current - first).TotalMilliseconds;
            return src.WithNewName($"-{elapsed}");
        }

        [MethodImpl(Inline)]
        public static FilePath Timestamped(FilePath src)
            => src.RenameFile(Timestamped(src.FileName));
        
        [MethodImpl(Inline)]
        public static FileName operator + (FileName name, FileExtension ext)
            => FileName.Define($"{name.Name}.{ext.Name}");


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
            => PartIdParser.single(WithoutExtension.Name.Remove("z0."));

        /// <summary>
        /// Determines whether the name of a file is of the form {owner}.{host}.{*}
        /// </summary>
        /// <param name="host">The owner to test</param>
        public bool HostedBy(ApiHostUri host)
            => StartsWith(string.Concat(host.Owner.Format(), Chars.Dot, host.Name.ToLower(), Chars.Dot));

        [MethodImpl(Inline)]
        public FileName ChangeExtension(FileExtension ext)
            => Define(Path.GetFileNameWithoutExtension(Name), ext);


        /// <summary>
        /// The file extension, if any
        /// </summary>
        Option<FileExtension> ExtOption
            => Ext.IsNonEmpty ? Option.some(Ext) : Option.none<FileExtension>();

        public FileName WithOwner(PartId part)
            => new FileName(
                    string.Concat(part.Format(), Chars.Dot, Path.GetFileNameWithoutExtension(Name)), 
                    ExtOption.MapValueOrElse(x => x.Name, () => string.Empty)
                    );
    }
}