//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;

    using Z0.Asm;

    using static core;
    using static Root;
    using static TextTools;
    using static EnvFolders;

    [ApiHost]
    public sealed partial class BdDisasm : Tool<BdDisasm, BdDisasmCmd>, IAsmTool
    {
        public AsmWorkspace Workspace {get; private set;}

        public FS.FolderPath BuildDir {get; private set;}

        public FS.FilePath ToolPath {get; set;}

        public BdDisasm()
            : base(Toolsets.bddiasm)
        {

        }


        protected override void Initialized()
        {
            Workspace = AsmWorkspace.create(Env.AsmWorkspace);
            BuildDir = Workspace.External + FS.folder(Id.Format()) + FS.folder(src) + FS.folder(build);
            ToolPath = BuildDir + FS.file(Id.Format(), FS.Exe);
        }

        public AsmToolchainSpec Spec(string src)
            => Workspace.ToolchainSpec(Toolsets.nasm, Toolsets.bddiasm, src);

        public BdDisasmCmd Cmd(in AsmToolchainSpec spec, bool bitfields = false , bool details = false, Bitness mode = Bitness.b64)
        {
            var dst = new BdDisasmCmd();
            dst.ToolPath = ToolPath;
            dst.BinPath = spec.BinPath;
            dst.EmitBitfields = bitfields;
            dst.EmitDetails = details;
            dst.Mode = mode;
            dst.Redirect = spec.DisasmPath.IsNonEmpty;
            dst.OutputFile = spec.DisasmPath;
            return dst;
        }

        [Op]
        public static uint render(Bitness src, ref uint i, Span<char> dst)
        {
            const string B16 = "b16";
            const string B32 = "b32";
            const string B64 = "b64";
            var i0 = i;
            var b = EmptyString;
            switch(src)
            {
                case Bitness.b16:
                    b = B16;
                break;
                case Bitness.b32:
                    b = B32;
                break;
                case Bitness.b64:
                    b = B64;
                break;
            }

            if(nonempty(b))
                copy(b, ref i, dst);

            return i - i0;
        }

        [Op]
        protected override uint Render(BdDisasmCmd src, ref uint i, Span<char> dst)
        {
            var i0 = i;

            const char Specifier = Chars.Dash;
            const string Bits = "bits";
            const string Exi = "exi";
            const char Redirect = '>';

            var tool = src.ToolPath.Format(PathSeparator.BS);
            copy(tool, ref i, dst);

            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Specifier;
            render(src.Mode, ref i, dst);

            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Specifier;
            seek(dst,i++) = Chars.f;
            seek(dst,i++) = Chars.Space;
            copy(src.BinPath.Format(PathSeparator.BS), ref i, dst);

            if(src.EmitBitfields)
            {
                seek(dst,i++) = Chars.Space;
                seek(dst,i++) = Specifier;
                copy(Bits, ref i, dst);
            }

            if(src.EmitDetails)
            {
                seek(dst,i++) = Chars.Space;
                seek(dst,i++) = Specifier;
                copy(Exi, ref i, dst);
            }

            // if(src.Redirect)
            // {
            //     seek(dst,i++) = Chars.Space;
            //     seek(dst,i++) = Redirect;
            //     seek(dst,i++) = Chars.Space;
            //     copy(src.OutputFile.Format(PathSeparator.BS), ref i, dst);
            // }

            return i - i0;
        }
    }
}