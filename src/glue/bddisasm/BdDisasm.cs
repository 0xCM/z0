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
    using static SymbolicTools;
    using static EnvFolders;

    [ApiHost]
    public sealed partial class BdDisasm : Tool<BdDisasm, BdDisasmCmd>, IAsmTool
    {
        public AsmWorkspace Workspace {get; private set;}

        public FS.FilePath ToolPath {get; set;}

        public BdDisasm()
            : base(Toolspace.bddiasm)
        {

        }

        protected override void Initialized()
        {
            Workspace = AsmWorkspace.create(Env.AsmWorkspace);
            ToolPath = Workspace.ToolPath(Toolspace.bddiasm);
        }

        public BdDisasmCmd Cmd(in AsmToolchainSpec spec, bool bitfields = false , bool details = false)
        {
            var dst = new BdDisasmCmd();
            dst.ToolPath = ToolPath;
            dst.BinPath = spec.BinPath;
            dst.EmitBitfields = bitfields;
            dst.EmitDetails = details;
            dst.AsmBitMode = spec.AsmBitMode;
            dst.OutputPath = spec.DisasmPath;
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

            var tool = src.ToolPath.Format(PathSeparator.BS);
            copy(tool, ref i, dst);

            seek(dst,i++) = Chars.Space;
            seek(dst,i++) = Specifier;
            render(src.AsmBitMode, ref i, dst);

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

            return i - i0;
        }
    }
}