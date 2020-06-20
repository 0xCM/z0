//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using K = PartFileKind;

    [ApiHost]
    public readonly struct PartFileKinds : IApiHost<PartFileKinds>
    {
        const int KindCount = 4;

        public static PartFileKinds Service()
        {
            var kindSize = Root.size<FileKind>();
            var buffer = new FileKind[KindCount + 1];
            var dst = buffer.ToSpan();
            Root.seek(dst,0) = None;
            Root.seek(dst,1) = Extract;
            Root.seek(dst,2) = Parsed;
            Root.seek(dst,3) = Asm;
            Root.seek(dst,4) = Hex;            
            return new PartFileKinds(buffer);
        }
        
        readonly FileKind[] KindData;
        
        PartFileKinds(FileKind[] data)
        {
            KindData = data;
        }

        public static FileKind<PartFileKind> None
        {
            [MethodImpl(Inline)]
            get => default;
        }
        
        public static ExtractKind Extract
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static ParsedKind Parsed 
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static AsmKind Asm 
        {
            [MethodImpl(Inline)]
            get => default;
        }

        public static HexKind Hex 
        {
            [MethodImpl(Inline)]
            get => default;
        }

        [MethodImpl(Inline), Op]
        public FileKind<PartFileKind> kind(PartFileKind k)
            => Root.cast<FileKind,FileKind<PartFileKind>>(in KindData[(int)k]);

        [Op]
        public static FileKind<PartFileKind> kindSwitch(PartFileKind k)
            => k switch{
                K.Extract => Extract,
                K.Parsed => Parsed,
                K.Asm => Asm,
                K.Hex => Hex,
                _ => None,
            };

        public readonly struct ExtractKind : IFileKind<ExtractKind,PartFileKind>
        {
            public const string ExtensionName = "x.csv";

            public const PartFileKind Classifier = PartFileKind.Extract;

            [MethodImpl(Inline)]
            public static implicit operator FileKind<PartFileKind>(ExtractKind src)
                => FileKinds.define(Classifier,ExtensionName);

            [MethodImpl(Inline)]
            public static implicit operator FileKind(ExtractKind src)
                => FileKinds.define(Classifier,ExtensionName);

            public PartFileKind Kind 
            {
                [MethodImpl(Inline)]
                get => Classifier;
            }

            public asci8 Ext 
            {
                [MethodImpl(Inline)]
                get => ExtensionName;
            }
        }

        public readonly struct ParsedKind  : IFileKind<ParsedKind,PartFileKind>
        {
            public const string ExtensionName = "p.csv";

            public const PartFileKind Classifier = PartFileKind.Parsed;

            [MethodImpl(Inline)]
            public static implicit operator FileKind<PartFileKind>(ParsedKind src)
                => FileKinds.define(Classifier, ExtensionName);
            
            [MethodImpl(Inline)]
            public static implicit operator FileKind(ParsedKind src)
                => FileKinds.define(Classifier,ExtensionName);

            public PartFileKind Kind 
            {
                [MethodImpl(Inline)]
                get => Classifier;
            }

            public asci8 Ext 
            {
                [MethodImpl(Inline)]
                get => ExtensionName;
            }
        }

        public readonly struct AsmKind  : IFileKind<AsmKind,PartFileKind>
        {
            public const string ExtensionName = "asm";

            public const PartFileKind Classifier = PartFileKind.Asm;

            [MethodImpl(Inline)]
            public static implicit operator FileKind<PartFileKind>(AsmKind src)
                => FileKinds.define(Classifier, ExtensionName);            

            [MethodImpl(Inline)]
            public static implicit operator FileKind(AsmKind src)
                => FileKinds.define(Classifier,ExtensionName);

            public PartFileKind Kind 
            {
                [MethodImpl(Inline)]
                get => Classifier;
            }

            public asci8 Ext 
            {
                [MethodImpl(Inline)]
                get => ExtensionName;
            }
        }

        public readonly struct HexKind  : IFileKind<HexKind,PartFileKind>
        {
            public const string ExtensionName = "hex";

            public const PartFileKind Classifier = PartFileKind.Hex;

            [MethodImpl(Inline)]
            public static implicit operator FileKind<PartFileKind>(HexKind src)
                => FileKinds.define(Classifier, ExtensionName);            

            [MethodImpl(Inline)]
            public static implicit operator FileKind(HexKind src)
                => FileKinds.define(Classifier,ExtensionName);

            public PartFileKind Kind 
            {
                [MethodImpl(Inline)]
                get => Classifier;
            }

            public asci8 Ext 
            {
                [MethodImpl(Inline)]
                get => ExtensionName;
            }
        }
    }
}